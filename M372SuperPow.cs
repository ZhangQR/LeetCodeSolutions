namespace LeetCodeSolutions
{
    /// <summary>
    /// 笨蛋解法，自然超时了
    /// </summary>
    public class M372SuperPow
    {
        public int SuperPow(int a, int[] b)
        {
            bool isZero = true;
            long crtResult = 1;
            int bLength;
            while (true)
            {
                isZero = true;
                foreach (var num in b)
                {
                    if (num != 0)
                    {
                        isZero = false;
                        break;
                    }
                }
                if (isZero)
                {
                    return (int)crtResult;
                }
                
                bLength = b.Length;
                if (b[bLength-1] > 0)
                {
                    b[bLength - 1]--;
                }
                else
                {
                    b[bLength - 1] = 9;
                    for (int i = bLength - 2; i >= 0; i--)
                    {
                        if (b[i] > 0)
                        {
                            b[i]--;
                            break;
                        }
                        b[i] = 9;
                    }
                }
                crtResult = a * crtResult % 1337;
            }
            return (int)crtResult;
        }
    }
}