using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // ARANGE 

            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {

                EmailAdress = "abc@abc.com",
                FirstName = "Normanas",
                LastName = "Necionis"


            };

            //ACT
            var actual = customerRepository.Retrieve(1);

            // assert 

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);




        }
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // ARANGE 

            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {

                EmailAdress = "abc@abc.com",
                FirstName = "Normanas",
                LastName = "Necionis",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot row",
                        City = "Hobbiton",
                        StateProvince = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"

                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        StateProvince = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"

                    }

                }
            };

            //ACT
            var actual = customerRepository.Retrieve(1);

            // assert 

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].StateProvince, actual.AddressList[i].StateProvince);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);

            }




        }
    }
}

