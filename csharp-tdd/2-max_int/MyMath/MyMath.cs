using System;
using System.Collections.Generic;

namespace MyMath
{
    public static class Operations
    {
        public static int Max(List<int> nums)
        {
            // Check if nums is empty
            if (nums.Count == 0)
            {
                return 0;
            }

            // Initialize max to the first element in the list
            int max = nums[0];

            // Iterate through the list and update max if a larger number is found
            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            // Return the max number
            return max;
        }
    }
}
