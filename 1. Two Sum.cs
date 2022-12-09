using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Solution
    {
        public static void Main_DEPRECATED()//(String[] args)
        {
            int[] twoSumIndex = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine(twoSumIndex[0]);
            Console.WriteLine(twoSumIndex[1]);
            Console.WriteLine();
            int[] twoSumIndex2 = TwoSum(new int[] { 3, 2, 4 }, 6);
            Console.WriteLine(twoSumIndex2[0]);
            Console.WriteLine(twoSumIndex2[1]);
            Console.WriteLine();
            int[] twoSumIndex3 = TwoSum(new int[] { 3, 3 }, 6);
            Console.WriteLine(twoSumIndex3[0]);
            Console.WriteLine(twoSumIndex3[1]);
            Console.WriteLine();
            int[] twoSumIndex4 = TwoSum(new int[] { 0, 4, 3, 0 }, 0);
            Console.WriteLine(twoSumIndex4[0]);
            Console.WriteLine(twoSumIndex4[1]);
            Console.WriteLine();
            int[] twoSumIndex5 = TwoSum(new int[] { -3, 4, 3, 90 }, 0);
            Console.WriteLine(twoSumIndex5[0]);
            Console.WriteLine(twoSumIndex5[1]);
        }


        public static int[] TwoSum(int[] nums, int target)
        {

            int[] twoSumIndex = new int[2];
            bool numMatched = false;

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {

                    if (nums[i] + nums[j] == target)
                    {
                        numMatched = true;
                        twoSumIndex = new int[2] { i, j };
                        j = nums.Length - 1;
                    }
                }

            }


            return twoSumIndex;


        }

    }
}
