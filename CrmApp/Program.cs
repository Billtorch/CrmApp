using System;
using System.Collections.Generic;

namespace CrmApp
{
    class AnotherClass
    {
        static void Main()
        {
            Ui ui = new Ui();

            Product myProduct = ui.CreateProduct();

            Customer customer = new Customer();

            Customer myCustomer = ui.CreateCustomer();

            if (myProduct != null)
            {
                myProduct.Print();


                decimal total = myProduct.TotalCost;
                Console.WriteLine(total);
            }
            if (myCustomer != null)
            {
                myCustomer.Print();


                
                
            }
            Product myProduct1 = ui.CreateProduct();
            Product myProduct2 = ui.CreateProduct();

            //meta thn new panta akolouthei o constructor 
            List<Product> products = new List<Product>
            {
                myProduct,
                myProduct1,
                myProduct2
            };

            int howManyLow = 0;
            int howManyMedium = 0;
            int howManyHigh = 0;
            foreach (Product p in products)
            {
                //topiki metavliti isxuei mono edw mesa
                Console.WriteLine(p.GetRange());
                if (p.GetRange() == "low") howManyLow++;
                if (p.GetRange() == "medium") howManyMedium++;
                if (p.GetRange() == "high") howManyHigh++;

            }

            Console.WriteLine($"howManyLow= + { howManyLow}"   );
            Console.WriteLine($"howManyMedium= + { howManyMedium}"   );
            Console.WriteLine($"howManyHigh=  + { howManyHigh}"  );

            /*  Console.WriteLine("-----Not preferred approach-------");
              for(int i=0; i<products.Count; i++)
              {
                  Console.WriteLine(products[i]);
              }

              Console.WriteLine("----Not preferred approach2----");
              int index = 0;
              while(index<products.Count)
              {
                  Console.WriteLine(products[index]);
                  index++;

              }*/

            

                
            
        }
        
    }

}