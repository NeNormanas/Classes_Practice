using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange

            Customer customer1 = new Customer
            {
                FirstName = "Normanas",
                LastName = "Necionis"
            };
            string expected = "Necionis, Normanas";


            // -- Act 

            string actual = customer1.FullName;


            // -- Assert

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange

            Customer customer1 = new Customer
            {

                LastName = "Necionis"
            };
            string expected = "Necionis";


            // -- Act 

            string actual = customer1.FullName;


            // -- Assert

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange

            Customer customer1 = new Customer
            {
                FirstName = "Normanas",

            };
            string expected = "Normanas";


            // -- Act 

            string actual = customer1.FullName;


            // -- Assert

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange

            var c1 = new Customer();
            c1.FirstName = "Jonas";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Petras";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rose";
            Customer.InstanceCount += 1;

            // -- Act 




            // -- Assert

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange

            var customer = new Customer
            {
                LastName = "Necionis",
                EmailAdress = "abc@abc.com"

            };

            var expected = true;

            // -- Act 

            var actual = customer.Validate();


            // -- Assert

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange

            var customer = new Customer
            {
                
                EmailAdress = "abc@abc.com"

            };

            var expected = false;

            // -- Act 

            var actual = customer.Validate();


            // -- Assert

            Assert.AreEqual(expected, actual);


        }

    }
}
