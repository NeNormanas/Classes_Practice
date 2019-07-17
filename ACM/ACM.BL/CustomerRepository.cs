using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int customerId) // grazina klienta pagal ID
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAdress = "abc@abc.com";
                customer.FirstName = "Normanas";
                customer.LastName = "Necionis";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
