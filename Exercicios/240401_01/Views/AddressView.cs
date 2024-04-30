using _240401_01.Controllers;
using _240401_01.Models;
using _240401_01.Repository;
using _240401_01.Data;

namespace _240401_01.Views
{
    public class AddressView
    {
        private AddressController addressController;
        public AddressView()
        {
            addressController = new AddressController();
            this.Init();
        }

        private void Init()
        {
        }
        public Address Insert()
        {

            Address address = new Address();

            Console.WriteLine("****************");
            Console.WriteLine("INSERIR ENDEREÇO");
            Console.WriteLine("****************");

            Console.WriteLine("Qual o tipo do endereço?");
            Console.WriteLine("1 - Residencial");
            Console.WriteLine("2 - Comercial");
            Console.WriteLine("3 - Outros");
            int tpEndereco = Convert.ToInt32(Console.ReadLine());
            switch (tpEndereco)
            {
                case 1:
                    address.Type = AddressType.Residential;
                break;
                case 2:
                    address.Type = AddressType.Commercial;
                break;
                case 3:
                    address.Type = AddressType.Other;
                break;
            }
            Console.WriteLine("Rua: ");
            address.Street = Console.ReadLine();

            Console.WriteLine("Bairro: ");
            address.District = Console.ReadLine();

            Console.WriteLine("CEP: ");
            address.ZipCode = Console.ReadLine();

            Console.WriteLine("Cidade: ");
            address.City = Console.ReadLine();

            Console.WriteLine("Estado: ");
            address.FederalState = Console.ReadLine();

            Console.WriteLine("País: ");
            address.Country = Console.ReadLine();

            Console.WriteLine("Endereço padrão? ");
            Console.WriteLine("1 - Sim / 2 - Não");
            int IsDefault = Convert.ToInt32(Console.ReadLine());
            address.IsDefault = (IsDefault == 1 ? true : false);

            addressController.Insert(address);

            return address;
        }
    }
}