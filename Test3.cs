using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class AlgebraEquaton
    {
        public void Test3(string[] args)
        {
            double x1;
            double x2;
            double x;
            double y;
            double D;

            double a;
            double b;
            double c;

            Console.WriteLine("Calculate the root of a quadratic equation");
            Console.WriteLine("Enter a value for a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for c");
            c = Convert.ToInt32(Console.ReadLine());

            if (a != 0)
            {
                D = b * b - 4 * a * c;
            }
            else
            {
                Console.WriteLine("Quadratic Equation is Not Possible");
            }


            D = ((b * b) - (4 * a * c));
            if (D == 0)
            {
                x1 = ((-b) / (2 * a));
                x2 = x1;
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
                Console.WriteLine("Both Roots Are Real And Equal");
            }
            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Both Roots Are Real And Different");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                D = -D;
                x = ((-b) / (2 * a));
                y = (Math.Sqrt(D) / (2 * a));
                Console.WriteLine("Root Are {0,8:f4}+{1,8:f4}i or {2,8:f4}-{3,8:f4}i", x , y, x, y);
            }
        }
    }
}
