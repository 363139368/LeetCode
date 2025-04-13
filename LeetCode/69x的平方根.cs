namespace LeetCode
{
    public class _69x的平方根
    {
        public int MySqrt(int x)
        {
            if (x <= 1)
                return x;

            var min = 0;
            var max = x;
            int sq, mid;
            while (min <= max)
            {
                mid = min + (max - min) / 2;
                sq = x / mid;

                if (mid == sq)
                    return mid;
                if (sq > mid)
                    min = mid + 1;
                else
                    max = mid - 1;
            }

            return max;
        }
    }
}