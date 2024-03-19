using _240318_01.Models;

Customer c1 = new Customer();

c1.CustomerId = 1;
c1.FirstName = "Guilherme";
c1.LastName = "Schweitzer";
c1.BirthDate = new DateTime();
c1.EmailAddress = "guischweitzer@unoesc.edu.br";

Address address1 = new Address();
address1.AddressId = 1;
address1.Street = "Marlene Weber Saint";
address1.District = "Alto da Boa Vista";
address1.City = "Videira";
address1.Number = 106;
address1.FederalState = "SC";
address1.Country = "Brasil";
address1.ZipCode = "89561-000";
address1.AddressType = AddressType.Commercial;

c1.Addresses.Add(address1);

Console.WriteLine("ENDEREÇOS:");
foreach(var ad in c1.Addresses)
{
    Console.WriteLine("---------------");
    Console.WriteLine($"Rua: {ad.Street}");
    Console.WriteLine($"Bairro: {ad.District}");
    Console.WriteLine($"Número: {ad.Number}");
    Console.WriteLine($"Cidade: {ad.City}");
    Console.WriteLine($"Estado: {ad.FederalState}");
    Console.WriteLine($"País: {ad.Country}");
}

Console.WriteLine( $"Nome: {c1.FirstName} {c1.LastName}" );
Console.WriteLine( $"Email: {c1.EmailAddress}");