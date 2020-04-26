using System;

namespace CrmApp
{
    class AnotherClass
    {
        static void Main()
        {
            Product myProduct = new Product(1)
            {
                Code = "A1",
                Name = "Chocolate",
                Price = 1.2m,
                Quantity = 10
            };

            myProduct.Print();


            Product a1 = new Product(2)
            {

                Code = "A123",
                Name = "Chicklets"
            };

            a1.Print();

            decimal total = myProduct.TotalCost + a1.TotalCost;
            Console.WriteLine(total);


        }


    }
}