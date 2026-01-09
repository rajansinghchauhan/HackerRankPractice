using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class BetweenTwoSets
    {
        // Function to compute GCD of two numbers
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Function to compute LCM of two numbers
        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        // Function to compute LCM of an array
        static int LCMArray(List<int> arr)
        {
            int result = arr[0];
            for (int i = 1; i < arr.Count; i++)
            {
                result = LCM(result, arr[i]);
            }
            return result;
        }

        // Function to compute GCD of an array
        static int GCDArray(List<int> arr)
        {
            int result = arr[0];
            for (int i = 1; i < arr.Count; i++)
            {
                result = GCD(result, arr[i]);
            }
            return result;
        }


        public int getTotalX(List<int> a, List<int> b)
        {
            int lcmA = LCMArray(a);
            int gcdB = GCDArray(b);

            int count = 0;
            for (int x = lcmA; x <= gcdB; x += lcmA)
            {
                if (gcdB % x == 0)
                {
                    count++;
                }
            }
            return count;

        }
    }
}
