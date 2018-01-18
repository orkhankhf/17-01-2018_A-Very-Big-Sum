using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace a_very_big_sum
{
    class Program
    {
        static long aVeryBigSum(int n, long[] ar)
        {
            return ar.Sum();
            /*
            
            OR THIS

            long sum = 0;
            foreach (var i in ar)
            {
                sum += i;
            }
            return sum;*/
        }
        static void Main(string[] args)
        {
            /*
             input this;
             5
             1000000001 1000000002 1000000003 1000000004 1000000005
            */
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = aVeryBigSum(n, ar);
            Console.WriteLine(result);
        }
    }
}
