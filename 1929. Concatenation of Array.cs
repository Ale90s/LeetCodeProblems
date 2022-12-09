using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1929._Concatenation_of_Array
{
   public class Solution {

        public static void Main_DEPRECATED()//(String[] args)
        {
            int[] concatenatedArray = GetConcatenation(new int[] { 1, 3, 2, 1 });

            foreach (var item in concatenatedArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("test");
        }

        public static int[] GetConcatenation(int[] nums) {

            int[] concatenatedArray = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                concatenatedArray[i] = nums[i];
                concatenatedArray[i + nums.Length] = nums[i];
            }

            return concatenatedArray;
        }
    }
}
