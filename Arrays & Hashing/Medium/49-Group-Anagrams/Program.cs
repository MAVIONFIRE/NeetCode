/*
 * Given an array of strings strs, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
Example 2:

Input: strs = [""]
Output: [[""]]
Example 3:

Input: strs = ["a"]
Output: [["a"]]
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Group_Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] test1 = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            string[] test2 = new string[] { "" };
            string[] test3 = new string[] { "a" };

            string[][] tests = {test1, test2, test3};

            foreach (var x in tests)
            {
                var answer = GroupAnagrams(x);
                foreach (var y in answer)
                {
                    foreach (var z in y)
                    {
                        Console.WriteLine(z);
                    }
                }
            }

            Console.ReadKey();
        }

        static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var group = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                var lowerString = str.ToLower();
                var key = new char[26];

                foreach (char letter in lowerString)
                {
                    key[letter - 'a']++;
                }

                string stringKey = new string(key);

                if (!group.ContainsKey(stringKey)) 
                {
                    group.Add(stringKey, new List<string>());
                }

                group[stringKey].Add(str);
            }

            return group.Values.ToList();
        }
    }
}
