using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a = 0b_1111_1000;
            uint b = 0b_1001_1100;
            uint c = a & b;
            Console.WriteLine(Convert.ToString(c, toBase: 2));

            uint d = a | b;
            Console.WriteLine(Convert.ToString(d, toBase: 2));

            uint e = a ^ b;
            Console.WriteLine(Convert.ToString(e, toBase: 2));  


            
        }
    }
}