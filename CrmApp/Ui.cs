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
            catch (Exception)
            {
                Console.WriteLine("You have not completed the questions properly." + "Please try again!");
                return null;
            }
        }

        public Customer CreateCustomer()


        {

            try
            {
                Customer customer = new Customer();
                Console.WriteLine("Gender");
                customer.Gender = Console.ReadLine();
                Console.WriteLine("Customer name");
                customer.Name2 = Console.ReadLine();
                Console.WriteLine("Surname");
                customer.Surname = Console.ReadLine();
                Console.WriteLine("Age");
                customer.Age = Int32.Parse(Console.ReadLine());


                return customer;
            }
            catch (Exception)
            {
                Console.WriteLine("You have not completed the questions properly." + "Please try again!");
                return null;
            }
        }
    }
}

