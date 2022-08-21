//Navid-Derakhshandeh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_s_Method
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("we're inside a for loop, and the value of i is {0}", i);


            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine("Please Enter the Time : ");

                double x = Double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter your point");

                double y = Double.Parse(Console.ReadLine());

                double z = 0.2 * y;

                double e = 1 - x;

                double s = e / 100;

                double a = z * s;

                double r = a * x;

                double b = y + r;

                Console.WriteLine("your next point is : {0}", b);
            }
            Console.ReadKey();

        }
    }
}
