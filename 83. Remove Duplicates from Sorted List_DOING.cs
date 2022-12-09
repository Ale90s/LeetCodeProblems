using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Class1
    {
        public static void Main(String[] a)
        {
            int[] sortedArray = new int[] { 1, 2, 3, 3 };

            List<int> duplicatedList = new List<int>(sortedArray);

            List<int> listWithoutDuplicated = new List<int>(deleteDuplicates(duplicatedList));

            foreach (var item in duplicatedList)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            foreach (var item in listWithoutDuplicated)
            {
                Console.Write(item);
            }
            Console.WriteLine();

        }

        public static List<int> deleteDuplicates(List<int> input)
        {
            List<int> listWithoutDuplicated = new List<int>();

            for (int i = 0; i < input.Count; i++)
            { 

                if (!listWithoutDuplicated.Contains(input[i]))
                    listWithoutDuplicated.Add(input[i]);
                
            }

            return listWithoutDuplicated;
        }
    }
}
