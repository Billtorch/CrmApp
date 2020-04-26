using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    class Customer
    {
        //fields
       

        //property that wraps the field code


        //other properties
        public string Gender { get; set; }
        public string Name2 { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Customer()
        {

        }


        public override string ToString()
        {
            return $"Gender= {Gender} Name= {Name2} Surname= {Surname} Age= {Age}";
        }
        public void Print()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }
    }

    


}

