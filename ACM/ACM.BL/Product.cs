using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        // KONSTRUKTORIUS 

        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        // PROPERTIES

        public int ProductId { get; private set; }


        private string _productName;

        public string ProductName
        { get
            {
                var stringHandler = new StringHandler();
                return stringHandler.InsertSpaces(_productName);
            }
            set
            {
                _productName = value;
            }
        }



        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; } // ?reiskia kad nulis irgi reiksme o ne teisiog langelis null.

        
        // METODAI


        public override string ToString() => ProductName;

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }
            if (CurrentPrice == null)
            {
                isValid = false;
            }
            return isValid;
        }




    }
}
