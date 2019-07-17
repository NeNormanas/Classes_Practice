using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Sunflowers gelius detalus aprasymas";
                product.CurrentPrice = 15.96M;
            }
            object myobject = new object();
            Console.WriteLine(myobject.ToString());
            Console.WriteLine(product.ToString());


            return product;
        }

        public bool Save (Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                    if (product.IsNew)
                    {
                        // call an insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
            }
            else
            {
                success = false;

            }
            return success;
        }
    }
}
