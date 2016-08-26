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

            while (parsedCount[9] > 0)
            {
                sb.Append(9);
                parsedCount[9] -= 1;
            }

            while (parsedCount[8] > 0)
            {
                sb.Append(8);
                parsedCount[8] -= 1;
            }

            while (parsedCount[7] > 0)
            {
                sb.Append(7);
                parsedCount[7] -= 1;
            }

            while (parsedCount[6] > 0)
            {
                sb.Append(6);
                parsedCount[6] -= 1;
            }

            while (parsedCount[5] > 0)
            {
                sb.Append(5);
                parsedCount[5] -= 1;
            }

            while (parsedCount[4] > 0)
            {
                sb.Append(4);
                parsedCount[4] -= 1;
            }

            while (parsedCount[3] > 0)
            {
                sb.Append(3);
                parsedCount[3] -= 1;
            }

            while (parsedCount[2] > 0)
            {
                sb.Append(2);
                parsedCount[2] -= 1;
            }

            while (parsedCount[1] > 0)
            {
                sb.Append(1);
                parsedCount[1] -= 1;
            }

            while (parsedCount[0] > 0)
            {
                sb.Append(0);
                parsedCount[0] -= 1;
            }

            Console.Write(sb.ToString());

            return Int32.Parse(sb.ToString());
        }
    }
}
