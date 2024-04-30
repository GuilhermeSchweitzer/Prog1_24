using _240401_01.Views;
using _240401_01.Controllers;
using _240401_01.Models;
using _240401_01.Data;
using _240401_01.Repository;

namespace _240401_01.Views

{
    public class CustomerView
    {
        {
        private CustomerController customerController;
        private AddressView addressView;
        this.Init()
        }
        public CustomerView()
        {
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("Menu Customer");
            Console.WriteLine("*************");
            Console.WriteLine("");

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir o consumidor");
                Console.WriteLine("2 - Pesquisar o consumidor");
                Console.WriteLine("3 - Listar o consumidor");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch(menu)
                    {
                        case 0:
                            aux = false;
                        break;
                        case 1:
                        break;
                        case 2:
                        break;
                        case 3:
                        break;
                        default:
                            Console.WriteLine("Opção Inválida.");
                            aux = true;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Opção inválida.");
                    menu = -1;
                }
            }while(aux);
        }

        private void InsertCustomer()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("INSERIR NOVO CONSUMIDOR");
            Console.WriteLine("***********************");

            Customer customer = new Customer();
            Console.Write("Nome: ");
            customer.Name = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Email: ");
            customer.EmailAddress = Console.ReadLine();
            Console.WriteLine("");

             int aux = 0;
             do{
                Console.Write("Deseja informar endereço?");
                Console.WriteLine("0 - Não");
                Console.WriteLine("1 - Sim");
                try
                {
                    aux = Convert.ToInt32(Console.ReadLine());
                    if(aux == 1)
                    {
                        customer.Addresses.Add(addressView.Insert());
                    }
                    else if( aux == 0 )
                    {
                        break;
                    }
                    else
                    {
                    aux = 1;
                    Console.WriteLine("Opção inváida.");
                    Console.WriteLine("Tente novamente.");
                    }
                }
                catch
                {
                    aux = 1;
                    Console.WriteLine("Opção inváida.");
                    Console.WriteLine("Tente novamente.");
                }
             }while(aux != 0);
        }
    }
}