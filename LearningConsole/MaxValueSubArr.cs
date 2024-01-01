namespace LearningConsole;

/// <summary>
/// Example 1:
///
/// Input: nums = [1,5,4,2,9,9,9], k = 3
/// Output: 15
/// Explanation: The subarrays of nums with length 3 are:
/// - [1,5,4] which meets the requirements and has a sum of 10.
/// - [5,4,2] which meets the requirements and has a sum of 11.
/// - [4,2,9] which meets the requirements and has a sum of 15.
/// - [2,9,9] which does not meet the requirements because the element 9 is repeated.
/// - [9,9,9] which does not meet the requirements because the element 9 is repeated.
///     We return 15 because it is the maximum subarray sum of all the subarrays that meet the conditions
/// Example 2:
/// 
/// Input: nums = [4,4,4], k = 3
/// Output: 0
/// Explanation: The subarrays of nums with length 3 are:
/// - [4,4,4] which does not meet the requirements because the element 4 is repeated.
///     We return 0 because no subarrays meet the conditions.
/// </summary>
public class MaximumSubarraySumClass {
    public long MaximumSubarraySum(int[] nums, int k)
    {
        long maxSubArrVal = 0;
        var numsLn = nums.Length;
        
        for (var i = 0; i < numsLn; i++)
        {
            var subArrRange = i + k > numsLn ? numsLn : i + k;
            var subArr = nums[i..subArrRange];

            if (subArr.Length != k)
            {
                return maxSubArrVal;
            }
            
            var subArrRes = 0;
            var seenValues = new HashSet<int>();

            foreach (var val in subArr)
            {
                if (!seenValues.Add(val))
                {
                    subArrRes = 0;

                    break;
                }

                subArrRes += val;
            }

            if (subArrRes > maxSubArrVal)
            {
                maxSubArrVal = subArrRes;
            }
        }
        
        return maxSubArrVal;
    }
}