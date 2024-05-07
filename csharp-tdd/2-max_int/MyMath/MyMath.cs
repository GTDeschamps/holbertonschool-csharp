using System;
using System.Collections.Generic;

namespace MyMath
{
    public static class Operations
    {
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }

            int max = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            return max;
        }
    }
}
