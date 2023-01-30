using System;

namespace _1._Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // example test cases
            //int[] nums = { 2, 11, 7, 5 };
            //int target = 9;
            int[] nums = { 3, 3 };
            int target = 6; 

            int[] TwoSumArray = new int[2]; // blank array to add numbers into for result

            for (int i = 0; i < nums.Length; i++)
            {
                int iterationNum = nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    int jiterationNum = nums[j];
                    if (i == j) // if the iteration of i is the same iteration as j, skip it 
                    {
                        continue;
                    }
                    if (iterationNum + jiterationNum == target)
                    {
                        TwoSumArray[0] = i;
                        TwoSumArray[1] = j;
                        //return TwoSumArray;
                        Console.WriteLine(string.Join(",", TwoSumArray));
                        Console.ReadLine();
                    }
                }
            }
            //return TwoSumArray;
            Console.WriteLine(string.Join(",", TwoSumArray));
            Console.ReadLine();
        }
    }
}
