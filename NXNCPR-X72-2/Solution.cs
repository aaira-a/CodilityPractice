using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXNCPR_X72_2
{
    public class Solution
    {
        public static int solution(string s)
        {
            var number = Convert.ToInt32(s, 2);

            var steps = 0;

            while (number > 0)
            {
                if (number %2 == 1)
                {
                    number -= 1;
                    steps += 1;
                }

                if ((number !=0) && (number % 2 == 0))
                {
                    number /= 2;
                    steps += 1;
                }
            }

            return steps;
        }
    }
}
