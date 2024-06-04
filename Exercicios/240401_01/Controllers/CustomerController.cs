namespace _240401_01.Controllers;
using _240401_01.Models;
using _240401_01.Repository;
using _240401_01.Utils;


    public class CustomerController
    {
        private CustomerRepository customerRepository;

        public CustomerController()
        {
            customerRepository = new CustomerRepository();
        }
        public void Insert(Customer customer)
        {
            customerRepository.Save(customer);
        }
        public List<Customer> Get()
        {
            return customerRepository.Retrieve();
        }
        public Customer Get(int id)
        {
            return customerRepository.Retrieve(id);
        }
        public List<Customer> GetByName(string name)
        {
            return customerRepository.RetrieveByName(name);
        }
        public void ExportToDelimited()
        {
            List<Customer> list = customerRepository.Retrieve();

            string fileContent = string.Empty;
            foreach(var c in list)
            {
                fileContent += $"{c.PrintToExportDelimited()}\n";
            }

            string fileName = $"Customer_{DateTimeOffset.Now.ToUnixTimeSeconds()}.txt";
            ExportToFile.SaveToDelimitedTxt(fileName, fileContent);
        }

        public string ImportFromDelimited(string filePath, string delimiter)
        {
            bool result = true;
            string msgReturn = string.Empty;
            int lineCountSuccess = 0;
            int lineCountError = 0;
            int lineTotalCount = 0;
            try
            {
                if(!File.Exists(filePath))
                    return "Arquivo não encontrado!";

                using(StreamReader sr = new StreamReader(filePath))
                {
                    string line = string.Empty;
                    while((line = sr.ReadLine()) != null)
                    {
                        lineTotalCount++;
                        if(customerRepository
                            .ImportFromTxt(line, delimiter))
                        {
                            result = false;
                            lineCountError++;
                        }
                        else
                        {
                            lineCountSuccess++;
                        }
                        result = customerRepository.ImportFromTxt(line, delimiter);
                    }
                }
            }
            catch (SystemException ex)
            {
                return $"ERRO: {ex.Message}";
            }

            if(result)
                msgReturn = "Dados importados com sucesso";
            else
                msgReturn = "Dados parcialmente importados";
            msgReturn += $"\nTotal de linhas: {lineTotalCount}";
            msgReturn += $"\nSuccess: {lineCountSuccess}";
            msgReturn += $"\nErro: {lineCountError}";

            return msgReturn;
        }
    }
