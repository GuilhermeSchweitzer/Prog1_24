using _240401_01.Models;
using _240401_01.Data;
using _240401_01.Repository;
using _240401_01.Controllers;

namespace _240401_01.Controllers
{
    public class AddressController
    {
        private AddressRepository addressRepository;
        public AddressController()
        {
            this.addressRepository = new AddressRepository();
        }

        public Address Insert(Address address)
        {
            this.addressRepository.Create(address);
            return address;
        }
                public Address Get(int id)
        {
            return addressRepository.Read(id);
        }
        public List<Address> Get()
        {
            return addressRepository.Read();
        }
    }
}