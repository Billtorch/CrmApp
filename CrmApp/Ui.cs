using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    class Ui
    {
        public Product CreateProduct()


        {

            try
            {
                Product product = new Product();
                Console.WriteLine("Give the code");
                product.Code = Console.ReadLine();
                Console.WriteLine("Give the name");
                product.Name = Console.ReadLine();
                Console.WriteLine("Give the price");
                product.Price = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("Give the Quantity");
                product.Quantity = Int32.Parse(Console.ReadLine());

                
                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine("You have not completed the questions properly."+ "Please try again!");
                return null;
            }
        }
    }
}

