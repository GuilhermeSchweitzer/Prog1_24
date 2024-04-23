using _240401_01.Models;
using _240401_01.Views;

bool aux = true;
do{
    Console.WriteLine("***********************");
    Console.WriteLine("Meu Programa de Pedidos");
    Console.WriteLine("***********************");
    Console.WriteLine();

    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Produtos");
    Console.WriteLine("3 - Pedidos");
    Console.WriteLine("0 - SAIR");

    int menu = 0;

    try
    {
        menu = Convert.ToInt32(Console.ReadLine());
        switch(menu)
        {
            case 1:
                CustomerView customerView = new CustomerView();
            break;
            case 2:
                ProductView productView = new ProductView();
            break;
            case 3:
            break;
            case 0:
                aux = false;
                Console.WriteLine("Obrigado e volte sempre!");
            break;
            default:
            Console.WriteLine("Opção Inválida.");
            menu = -1;
            break;
        }
    }
    catch
    {
        Console.WriteLine("Opção Inválida.");
        aux = true;
    }

}while(aux);



/*
using _240401_01.Models;

Console.WriteLine("Hello, World!");

Customer c1 = new Customer();
c1.CustomerID = 1;
c1.Name = "Jaguara";
c1.EmailAddress = "jaguara@gmail.com";

Customer c2 = new Customer(2);
c1.Name = "Boca-Mole";
c1.EmailAddress = "bocamole@gmail.com";

Customer c3 = new Customer(3);
c1.CustomerID = 3;
c1.Name = "Nerso";
c1.EmailAddress = "nerso@gmail.com";
*/