namespace LeetCode
{
    public class BitCalculator
    {
        public int Add(int x, int y)
        {
            var res = x;
            while (y != 0)
            {
                var tmp = res ^ y;
                y = (y & res) << 1;
                res = tmp;
            }

            return res;
        }

        public int Subtract(int x, int y)
        {
            return Add(x, Negation(y));
        }

        public int Negation(int x)
        {
            return Add(~x, 1);
        }

        public int Multiply(int x, int y)
        {
            var isNeg = (x > 0 && y < 0) || (x < 0 && y > 0);
            if (x < 0) x = Negation(x);
            if (y < 0) y = Negation(y);
            var res = 0;
            while (y != 0)
            {
                if ((y & 1) > 0) res = Add(res, x);
                x <<= 1;
                y >>= 1;
            }

            return isNeg ? Negation(res) : res;
        }

        public int Divide(int x, int y)
        {
            if (x == int.MinValue && y == int.MinValue) return 1;
            if (x != int.MinValue && y != int.MinValue) return div(x, y);
            if (y == int.MinValue) return 0;
            if (y == Negation(1)) return int.MaxValue;

            if (y > 0)
            {
                x = Add(x, y);
                return Add(div(x, y), Negation(1));
            }

            if (y < 0)
            {
                x = Add(x, Negation(y));
                return Add(div(x, y), 1);
            }

            return 0;
        }

        public int div(int x, int y)
        {
            var isNegative = (x < 0) ^ (y < 0);

            if (x < 0) x = Negation(x);
            if (y < 0) y = Negation(y);

            var res = 0;

            var start = 15;
            if (x >> 15 > y) start = 30;

            for (var i = start; i >= 0; i = Subtract(i, 1))
            {
                var tmp = x >> i;
                if (tmp >= y)
                {
                    res |= 1 << i;
                    x = Subtract(x, y << i);
                }
            }

            return isNegative ? Negation(res) : res;
        }
    }
}