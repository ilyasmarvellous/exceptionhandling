using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;

            try
            {
                Console.Write("Enter first number : ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number : ");
                num2 = int.Parse(Console.ReadLine());
                sum = num1 + num2;
                Console.WriteLine(sum);
            }
            catch (Exception e)
            {
                Console.WriteLine("Not a proper format");
            }
            Console.ReadKey();
        }
    }
}
