using System.Text;

namespace LeetCodeSolutions
{
    public class S1816TruncateSentence
    {
        public string TruncateSentence(string s, int k)
        {
            int length = s.Length;
            StringBuilder sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                if (s[i] == ' ' && --k == 0)
                {
                    break;
                }
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}