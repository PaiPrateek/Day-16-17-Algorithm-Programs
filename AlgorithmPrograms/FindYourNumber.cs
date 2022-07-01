using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class FindYourNumber
    {
        public static void findYourNumber()
        {
            Console.Write("Enter a number : "); 
            int k = int.Parse(Console.ReadLine());

            int limit = (int)Math.Pow(2, k);

            Console.WriteLine("Imagine a number between 0 and " + limit + " in your mind:");

            int num = search(0, limit);
            Console.WriteLine("Your number is " + num);

        }
        public static int search(int lo, int hi)
        {
            if ((hi - lo) == 1)
            {
                return lo;
            }
                
            int mid = lo + (hi - lo) / 2;
            Console.Write("is your number less than " + mid + " : ");
            Console.WriteLine("Press 1 : Yes \n 0 : No");
            int flag = int.Parse(Console.ReadLine());
            if (flag==1)
            {
                return search(lo, mid);
            }
                
            else
            {
                return search(mid, hi);
            }
                
        }
    }
}
