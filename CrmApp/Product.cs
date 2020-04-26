﻿using System;
using System.Collections.Generic;
using System.Text;



namespace CrmApp
{
    class Product
    {
        private int category;
        private String code;



        public string Code
        {
            get { return "GR" + code; }
            set { code = value; }
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalCost { get { return Price * Quantity; } }



        public Product(int _category)
        {
            category = _category;
        }



        public Product()
        {



        }



        public override string ToString()
        {
            return "Name= " + Name
               + " Price= " + Price
               + " Quantity= " + Quantity
               + " TotalCost= " + TotalCost;
        }







        public void IncreasePrice(decimal percentage)
        {
            if (category == 1)
            {
                Price *= (1 + 0.1m);
            }
            else
            {
                Price *= (1 + percentage);
            }

        }



        public void Print()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }

    }




    class Shop
    {



    }
}
