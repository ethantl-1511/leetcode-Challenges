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

            // use two iterations, first to hold value of first iteration to check value of section iteration
            for (int i = 0; i < nums.Length; i++)
            {
                int iterationNum = nums[i]; // set value of array position, index i to variable
                for (int j = 0; j < nums.Length; j++)
                {
                    int jiterationNum = nums[j]; // set value of array position, index j to variable
                    if (i == j) // if the iteration of i is the same iteration as j, 
                                // skip it because we don't want [0,0], [1,1], etc.
                    {
                        continue;
                    }
                    if (iterationNum + jiterationNum == target) // if the values are equal to the target
                    {
                        TwoSumArray[0] = i; // add index position i to array
                        TwoSumArray[1] = j; // add index position j to array
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
