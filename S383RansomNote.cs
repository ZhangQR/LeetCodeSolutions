using System;

namespace LeetCodeSolutions
{
    public class S383RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] record = new int[26];
            foreach (var c in magazine)
            {
                record[c - 'a']++;
            }

            foreach (var c in ransomNote)
            {
                record[c - 'a']--;
                if (record[c - 'a'] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}