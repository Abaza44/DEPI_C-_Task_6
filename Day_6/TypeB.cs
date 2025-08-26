using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class TypeB : TypeA
    {
        public void print()
        {

           // Console.WriteLine(F); >> private
            Console.WriteLine(G);
            Console.WriteLine(H);
        }
    }
}
