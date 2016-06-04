using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    /**
     * this is the driver class of my program used to create new objects from the class hero
     * @class Hero
     * @method Main(string[]) args
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine("\nName: Shahzaib Malik   Student# 300852792   Course COMP123   Assignment 1");
            Console.WriteLine("\n___________________________________________________________________________");
            // created hero barry 
            Hero Barry = new Hero("Barry");
            // using the show method to show the abilities of the hero created
            Barry.Show();
            // using the fight method to determine the damage and the hit attempt
            Barry.Fight();
        }
    }
}
