using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class q3
    {
        static void Main(String[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Choice: ");
            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);

            }
            else if(ch== 2)
            {

            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            }
            else if (ch == 3)
            {

            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            }
            else if(ch==4)
            {

            Console.WriteLine("{0} % {1} = {2}", num1, num2, num1 % num2);
            }
        }
    }
}
