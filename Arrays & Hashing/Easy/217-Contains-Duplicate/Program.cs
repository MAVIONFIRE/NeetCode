/*
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

 

Example 1:

Input: nums = [1,2,3,1]
Output: true
Example 2:

Input: nums = [1,2,3,4]
Output: false
Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
 

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217_Contains_Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] test = {
                new int[] { 1, 2, 3, 1 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }
            };

            foreach (var x in test)
            {
                Console.WriteLine(ContainsDuplicate(x));
            }

            Console.ReadKey();
        }

        static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (var x in nums)
            {
                if (set.Contains(x)) return true;
                else set.Add(x);
            }

            return false;
        }

    }
}
