using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {

            // ARANGE
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Sunflowers gelius detalus aprasymas",
                ProductName = "Sunflowers"
            };
            // ACt 

            var actual = productRepository.Retrieve(2);

            //Assert 

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            



           
        }
        [TestMethod]
        public void SaveTestValid()
        {

            // ARANGE
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Sunflowers gelius detalus aprasymas",
                ProductName = "Sunflowers",
                HasChanges = true
            };
            // ACt 

            var actual = productRepository.Save(updatedProduct);

            //Assert 

            Assert.AreEqual(true, actual);





        }
        public void SaveTestMissingPrice()
        {

            // ARANGE
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Sunflowers gelius detalus aprasymas",
                ProductName = "Sunflowers",
                HasChanges = true
            };
            // ACt 

            var actual = productRepository.Save(updatedProduct);

            //Assert 

            Assert.AreEqual(false, actual);





        }
    }
}
