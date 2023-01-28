using System;
using System.Linq;

public class Solution
{
    public int[] SumZero(int n)
    {
        int[] numbers = new int[n]; // create int array to add numbers to from test case
        int num = n; // number variable for operations

        if (num == 1) // edge case for number 1
        {
            numbers[0] = 0; // add 0 to array
            return numbers;
        }

        for (int i = 0; i < n-1; i += 2) // iterate n times minus 1, increment by 2
        {
            numbers[i] = num; // add num to array at current index position
            numbers[i+1] = num * -1; // add negative version of num to array index+1
            num = num - 1; // subtracts 1 for next iteration
        }
        if (numbers.Length != n) // thi checks is for odd number cases
        {
            numbers[n-1] = 0; // adds 0 at the end of the array
        }
        return numbers;
    }
}