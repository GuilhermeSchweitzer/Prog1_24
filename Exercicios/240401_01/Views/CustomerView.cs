namespace _240401_01.Views
{
    public class CustomerView
    {
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
    }
}