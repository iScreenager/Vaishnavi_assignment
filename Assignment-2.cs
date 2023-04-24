using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignments
{
    class Assignment02
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 6, 3, 9 };

            for(int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("This is even: " + arr[i]);
                }
                else
                {
                    Console.WriteLine("This is odd: " + arr[i]);

                }
            }
        }
    }
}
