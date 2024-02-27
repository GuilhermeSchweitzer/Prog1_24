using System;

string message1 = System.String.Empty;
var message2 = "Bem-Vindo, favor preencher a ficha a seguir para prosseguir";

Console.WriteLine( message2 );

string name = String.Empty;
Console.WriteLine("Por favor, digite seu nome: ");
name = Console.ReadLine();
string email = String.Empty;
Console.WriteLine("Qual seu e-mail?");
email = Console.ReadLine();
string born = String.Empty;
Console.WriteLine("Que dia você nasceu? ");
born = Console.ReadLine();
string gender = String.Empty;
Console.WriteLine("Com qual gênero você se identifica? ");
gender = Console.ReadLine();
string CEP = String.Empty;
Console.WriteLine("Qual o seu CEP? ");
CEP = Console.ReadLine();
string street = String.Empty;
Console.WriteLine("Em que rua você mora?");
street = Console.ReadLine();
string number = String.Empty;
Console.WriteLine("Se sua casa tiver número, digite o número abaixo");
number = Console.ReadLine();
string UF = String.Empty;
Console.WriteLine("Qual sua Unidade Federal? ");
UF = Console.ReadLine();
string neighborhood = String.Empty;
Console.WriteLine("Qual o nome do seu bairro? ");
neighborhood = Console.ReadLine();
string city = String.Empty;
Console.WriteLine("Qual o nome da cidade em que você mora?");
city = Console.ReadLine();
string country = String.Empty;
Console.WriteLine("Em que país você mora?");
country = Console.ReadLine();

string result = $"Bem-vindo {name}! {email}  -  {gender} - {born} - {CEP} - {street} - {number} - {neighborhood} - {city} - {UF} - {country} ";
Console.WriteLine(result);
