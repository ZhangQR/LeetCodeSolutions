using System;

namespace LeetCodeSolutions
{
    public class S1005MaximizeSumOfArrayAfterKNegations
    {
        public int LargestSumAfterKNegations(int[] nums, int k) {
            Array.Sort(nums);
            int ret = 0;
            int length = nums.Length, i;
            bool isAbsMinFlip = false;
            for (i = 0; k > 0; i++)
            {
                if (i >= length && (k & 1) == 1)
                {
                    ret += 2 * nums[i - 1];
                    break;
                }
                if (nums[i] < 0)
                {
                    ret += -nums[i];
                    k--;
                }else if (nums[i] >= 0)
                {
                    if (nums[i] > 0 && (k & 1) == 1 )
                    {
                        int last = i == 0 ? nums[i] : -nums[i - 1];
                        if (last < nums[i])
                        {
                            ret -= 2 * last;
                        }
                        else
                        {
                            ret -= nums[i++];
                        }
                    }
                    break;
                }
            }

            for (; i < length; i++)
            {
                ret += nums[i];
            }
            return ret;
        }
    }
}