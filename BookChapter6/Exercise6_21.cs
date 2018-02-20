using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter6
{
    class Exercise6_21
    {
        public static void Main()
        {
            int size = 500;

            for(int i =3; i <= size; i++)
            {
                for(int j = 2; j <= i-1; j++)
                {
                    for(int z = 1; z <= j; z++)
                    {
                        if (i * i == (z * z + j * j))
                            Console.WriteLine("{0},{1},{2} is a Pythagorean triple", z,j,i);
                    }
                }
            }


        }


    }
}
