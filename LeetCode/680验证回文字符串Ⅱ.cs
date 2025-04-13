namespace LeetCode
{
    public class _680验证回文字符串Ⅱ
    {
        public bool ValidPalindrome(string s)
        {
            var l = 0;
            var r = s.Length - 1;

            var errorCount = 0;

            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                    continue;
                }

                errorCount++;
                break;
            }

            if (errorCount == 0)
                return true;

            var errorL = l;
            var errorR = r;

            var bl = true;

            l = errorL + 1;
            r = errorR;
            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                    continue;
                }

                bl = false;
                break;
            }

            if (bl)
                return true;

            var br = true;
            l = errorL;
            r = errorR - 1;
            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                    continue;
                }

                br = false;
                break;
            }

            return br;
        }
    }
}