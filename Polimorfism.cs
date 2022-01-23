// Example of Polimorfism in ClasePoly.Poly() Function

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class ClasePoly
    {
        public void Poly(object o)
        {
            Console.WriteLine(o.ToString());
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            ClasePoly x = new ClasePoly();
            x.Poly(42);
            x.Poly("abcd");
            x.Poly(12.345678901234m);
            x.Poly(new System.Drawing.Point(23, 45));
            Console.ReadKey();
        }
    }
}
