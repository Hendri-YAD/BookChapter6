using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter6
{
    class Exercise6_13
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine("{0} \t {1}", i, factorial(i));
            }


        }

        public static int factorial(int num)
        {        
            if (num == 1)
                return 1;
            else
                return num * factorial(num - 1);
        }


    }
}
