using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equi
{
    public class Solution
    {
        public static int solution(int[] A)
        {
            var length = A.Length;
            var totalSum = A.Sum();
            var leftSum = 0;
            var rightSum = 0;

            if (length <= 1)
            {
                return -1;
            }

            for (int i=0; i<length; i++)
            {
                var currentElement = A[i];

                rightSum = totalSum - leftSum - currentElement;
                
                if (leftSum == rightSum)
                {
                    return i;
                }

                leftSum =+ A[i];
            }

            return -1;
        }
    }
}
