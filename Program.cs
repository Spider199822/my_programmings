using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Antegral_polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            Polynomial p1 = new Polynomial(4);
            p1.Integral(p1);
            p1.print();
            Console.ReadKey();
        }
    }
}
