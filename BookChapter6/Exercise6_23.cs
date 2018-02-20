using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter6
{
    class Exercise6_23
    {
        public static void Main()
        {
            Console.Write("Please indicate the size of the diamond: ");
            int size = Convert.ToInt32(Console.ReadLine());

            displayDiamond(size);


        }

        static void displayDiamond(int n)
        {
            string s = "*";
            string space = " ";
           

            for(int i = 1; i <= n-1; i++)
            {
                Console.Write(space.PadLeft(n-i, ' '));                
                Console.WriteLine(s.PadLeft(2 * i - 1, '*'));                             
            }

            Console.WriteLine(s.PadRight(n * 2 - 1, '*'));

            for (int i = n-1; i >= 1; i--)
            {
                Console.Write(space.PadLeft(n - i, ' '));
                Console.WriteLine(s.PadLeft(2 * i - 1, '*'));
            }
        }


    }
}
