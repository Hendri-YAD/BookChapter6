using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter6
{
    class Exercise6_17
    {
        public static void Main()
        {


            bool toContinue = true;

            while(toContinue)
            {

                Console.Write("Please enter the product number and quantity sold separated by commas: ");
                string[] arr = Console.ReadLine().Split(',');
                int[] arrNum = new int[arr.Length];

                for (int i = 0; i < arr.Length; i++)
                {
                    arrNum[i] = Convert.ToInt32(arr[i]);
                }

                Console.WriteLine("Total retail value is {0:$0.00}", totalValue(arrNum[0], arrNum[1]));

                Console.Write("Please enter -1 to quit or enter 1 to continue: ");
                if (Convert.ToInt32(Console.ReadLine()) == -1)
                    toContinue = false;

                
            }
           
        }

        public static double totalValue(int prodNum, int quanSold)
        {

            switch (prodNum)
            {
                case 1:
                    return 2.98 * quanSold;
                case 2:
                    return 4.50 * quanSold;
                case 3:
                    return 9.98 * quanSold;
                default:
                    return 0;
            }
        }


    }
}
