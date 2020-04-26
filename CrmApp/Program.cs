using System;

namespace CrmApp
{
    class AnotherClass
    {
        static void Main()
        {
            Ui ui = new Ui();


            Product myProduct = ui.CreateProduct();
            if (myProduct != null) { 
            myProduct.Print();
            Product a1 = ui.CreateProduct();
            a1.Print();

            decimal total = myProduct.TotalCost + a1.TotalCost;
            Console.WriteLine(total);

            }
        }
    }
}