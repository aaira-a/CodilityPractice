using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXNCPR_X72_1
{
    public class Solution
    {
        public static int solution(int N)
        {
            var numberAsString = N.ToString();

            var parsedCount = new Dictionary<int, int>()
            {
                {0, 0},
                {1, 0},
                {2, 0},
                {3, 0},
                {4, 0},
                {5, 0},
                {6, 0},
                {7, 0},
                {8, 0},
                {9, 0}
            };

            foreach (var c in numberAsString)
            {
                var parsedDigit = Int32.Parse(c.ToString());
                parsedCount[parsedDigit] += 1;
            }

            var sb = new System.Text.StringBuilder();

            for (var i = 9; i >= 0; i-- )
            { 
                while (parsedCount[i] > 0)
                {
                    sb.Append(i);
                    parsedCount[i] -= 1;
                }
            }

            return Int32.Parse(sb.ToString());
        }
    }
}
