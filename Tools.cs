using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace LeetCodeSolutions
{
    public static class Tools
    {
        public static void Log(bool value)
        {
            Console.Write(value);
        }
        
        public static void Log(string value)
        {
            Console.Write(value);
        }
        
        public static void Log(int value)
        {
            Console.Write(value);
        }
        
        public static void Log(object value)
        {
            Console.Write(value);
        }
        
        public static void Log(float value)
        {
            Console.Write(value);
        }
        
        public static void Reverse(this StringBuilder sb)
        {
            char t;
            int end = sb.Length - 1;
            int start = 0;
    
            while (end - start > 0)
            {
                t = sb[end];
                sb[end] = sb[start];
                sb[start] = t;
                start++;
                end--;
            }
        }

        public static string CharToBinary(char c)
        {
            int length = sizeof(char) * 8;
            StringBuilder sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                sb.Append(c & 1);
                c >>= 1;
            }
            sb.Reverse();
            return sb.ToString();
        }
    }
}