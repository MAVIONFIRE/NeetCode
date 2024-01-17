/*
 * Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

 

Example 1:

Input: nums = [1,1,1,2,2,3], k = 2
Output: [1,2]
Example 2:

Input: nums = [1], k = 1
Output: [1]
 

Constraints:

1 <= nums.length <= 105
-104 <= nums[i] <= 104
k is in the range [1, the number of unique elements in the array].
It is guaranteed that the answer is unique.
 

Follow up: Your algorithm's time complexity must be better than O(n log n), where n is the array's size.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _347_Top_K_Frequent_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 1, 1, 1, 2, 2, 3 };
            int target = 2;
            var result = TopKFrequent(test, target);
            foreach(var x in result)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }

        static int[] TopKFrequent(int[] nums, int k)
        {
            int[] result = new int[k];
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            foreach (var x in nums)
            {
                if(!keyValuePairs.ContainsKey(x))
                {
                    keyValuePairs.Add(x, 0);
                }
                keyValuePairs[x]++;
            }

            var ordered = keyValuePairs.OrderByDescending(x => x.Value).Take(k).ToList();

            for (int i = 0 ; i < ordered.Count; i++)
            {
                result[i] = ordered[i].Key;
            }

            return result;
        }

    }
}
