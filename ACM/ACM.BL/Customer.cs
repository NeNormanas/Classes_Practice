using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL // Business logic
{
    public class Customer
    {
        // KONSTRUKTORIUS

        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public static int InstanceCount { get; set; }
        public int CustomerType { get; set; }


        public  List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }

        // kitas budas naudojant snippets
        public string EmailAdress { get; set; } //desini insert snipp

        public string FirstName { get; set; }

        // Ilgasis budas ideti property , jei gu nori dar extra codo
        // jeigu nereikia jokios papildomos logikos properciui datome auto
        private string _lastName;

        public string LastName
        {
            get
            { return _lastName; }
            set
            { _lastName = value; }
        }

        public string FullName // READ-ONLY, nes nera SET
        {
            get  // set nebereikia nes ir last ir forst name jau turi sukurtus
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }


        }

        public int customerId { get; set; }

        public override string ToString() => FullName;

        public bool Validate() // patikrinama ar ivede pavarde ir Emaila
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;

            return isValid;
        }
    }
}
