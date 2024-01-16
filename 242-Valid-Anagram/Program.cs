/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false
 

Constraints:

1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.
 

Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242_Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] test = {
            new string[] { "anagram", "nagaram" },
            new string[] { "rat", "car" },
            new string[] { "abc", "cba" }
            };

            foreach (var testCase in test)
            {
                bool areAnagrams = IsAnagram(testCase[0], testCase[1]);
                Console.WriteLine(areAnagrams);
           
            }

            Console.ReadKey();
        }

        static bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length) return false;
            if (s == t) return true;

            int[] sCount = new int[26];
            int[] tCount = new int[26];
            s = s.ToLower();
            t = t.ToLower();

            for (int i = 0; i < s.Length; i++)
            {
                sCount[s[i] - 'a']++;
            }

            for (int j = 0; j < t.Length; j++)
            {
                tCount[t[j] - 'a']++;
            }

            return sCount.SequenceEqual(tCount);
                
        }

    }
}
