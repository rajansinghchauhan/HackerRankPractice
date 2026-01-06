using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class AppleOrange
    {
        public void countApplesAndOranges(int houseStart, int houseEnd, int appleTree, int orangeTree, List<int> appleThrown, List<int> orangeThrown, int apples, int oranges)
        {
            List<int> appleLand = new List<int>();
            List<int> orangeLand = new List<int>();
            int appleLandCount = 0;
            int orangeLandCount = 0;

            foreach (int item in appleThrown)
            {
                appleLand.Add(appleTree + item);
            }

            foreach (int item in orangeThrown)
            {
                orangeLand.Add(orangeTree + item);
            }

            foreach (int item in appleLand)
            {
                if(item >= houseStart &&  item <= houseEnd)
                {
                    appleLandCount += 1;
                }
            }
            foreach (int item in orangeLand)
            {
                if (item >= houseStart && item <= houseEnd)
                {
                    orangeLandCount += 1;
                }
            }

            Console.WriteLine(appleLandCount);
            Console.WriteLine(orangeLandCount);
        }
    }
}
