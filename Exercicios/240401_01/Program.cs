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