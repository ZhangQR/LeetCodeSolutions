using System;
using System.Collections.Generic;
using System.Text;
using static LeetCodeSolutions.Tools;

namespace LeetCodeSolutions
{
    public class M423ReconstructOriginalDigitsFromEnglish
    {
        class EnglishNumber
        {
            public int keyIndex;
            public int digitalValue;
            public int[] valueIndexs;
            public string value;

            public EnglishNumber(string number, char key,int digitalValue)
            {
                keyIndex = CharToIndex(key);
                value = number;
                this.digitalValue = digitalValue;
                int length = number.Length;
                valueIndexs = new int[length];
                for(int i = 0;i<length;i++)
                {
                    valueIndexs[i] = CharToIndex(number[i]);
                }
            }
            private static int CharToIndex(char c)
            {
                return c - 'a';
            } 
        }

        class Pass
        {
            public EnglishNumber[] numbers;
        }

        private Pass pass1 = new Pass()
        {
            numbers = new[]
            {
                new EnglishNumber("eight", 'g',8),
                new EnglishNumber("four", 'u',4),
                new EnglishNumber("two", 'w',2),
                new EnglishNumber("six", 'x',6),
                new EnglishNumber("zero", 'z',0)
            }
        };

        private Pass pass2 = new Pass()
        {
            numbers = new[]
            {
                new EnglishNumber("five", 'f',5),
                new EnglishNumber("three", 'h',3),
                new EnglishNumber("one", 'o',1),
                new EnglishNumber("seven", 's',7),
            }
        };
        
        private Pass pass3 = new Pass()
        {
            numbers = new[]
            {
                new EnglishNumber("nine", 'i',9)
            }
        };

        private int[] letterNumberRecord = new int[26];
        private int[] resultRecord = new int[10];
        
        public string OriginalDigits(string s)
        {
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                letterNumberRecord[s[i] - 'a']++;
            }
            PassProcess(pass1);
            PassProcess(pass2);
            PassProcess(pass3);
            StringBuilder sb = new StringBuilder();
            for(int i = 0;i<10;i++)
            {
                sb.Append((char)(i+'0'),resultRecord[i]);
            }
            return sb.ToString();
        }

        private void PassProcess(Pass pass)
        {
            int length = pass.numbers.Length;
            for (int i = 0; i < length; i++)
            {
                EnglishNumber[] numbers = pass.numbers;
                int times = letterNumberRecord[numbers[i].keyIndex];
                ScratchOneNumber(numbers[i].value,times);
                resultRecord[numbers[i].digitalValue] += times;
            }
        }

        private void ScratchOneNumber(string number,int times)
        {
            foreach (var c in number)
            {
                letterNumberRecord[c - 'a'] -= times;
            }
        }
    }
}