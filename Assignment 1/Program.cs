using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            hero hero1 = new hero("thomas");
            hero1.show();
            
            hero1.Fight();
        }
    }
}
