using System;

namespace LeetCode
{
    public class LCR_002_二进制求和
    {
        public string AddBinary(string a, string b)
        {
            if (a == "0") return b;
            if (b == "0") return a;
            var cap = a.Length + b.Length;

            var res = new char[cap];
            var tmp = new char[cap];
            var tmp1 = new char[cap];
            var tmp2 = new char[cap];

            var aArr = a.ToCharArray();
            var bArr = b.ToCharArray();
            NoJinWeiAdd(aArr, bArr, ref res);
            GetJinWei(aArr, bArr, ref tmp);

            while (CheckContain1(tmp))
            {
                NoJinWeiAdd(res, tmp, ref tmp1);
                GetJinWei(res, tmp, ref tmp2);
                CopyArray(tmp1, ref res);
                CopyArray(tmp2, ref tmp);
            }

            var index = Array.FindIndex(res, c => c == '1');
            if (index == -1) return "0";

            return string.Concat(res).Substring(index);
        }

        public void CopyArray(char[] source, ref char[] tar)
        {
            if (source == null || source.Length == 0) return;
            if (tar.Length != source.Length) tar = new char[source.Length];

            for (var i = 0; i < tar.Length; i++) tar[i] = source[i];
        }

        public void GetJinWei(char[] a, char[] b, ref char[] res)
        {
            if (res.Length < a.Length && res.Length < b.Length) res = new char[res.Length * 2];
            if (res == null) res = new char[a.Length + b.Length];
            for (var i = 0; i < res.Length; i++)
            {
                if (i == 0)
                {
                    res[GetPostIndex(i, res)] = '0';
                    continue;
                }

                var aChar = GetPostChar(i - 1, a);
                var bChar = GetPostChar(i - 1, b);
                if (aChar == '1' && bChar == '1')
                    res[GetPostIndex(i, res)] = '1';
                else
                    res[GetPostIndex(i, res)] = '0';
            }
        }

        public void NoJinWeiAdd(char[] a, char[] b, ref char[] res)
        {
            if (res.Length < a.Length && res.Length < b.Length) res = new char[res.Length * 2];
            if (res == null) res = new char[a.Length + b.Length];

            for (var i = 0; i < res.Length; i++)
            {
                var aChar = GetPostChar(i, a);
                var bChar = GetPostChar(i, b);
                if (aChar != bChar)
                    res[GetPostIndex(i, res)] = '1';
                else
                    res[GetPostIndex(i, res)] = '0';
            }
        }

        public bool CheckContain1(char[] arr)
        {
            if (arr == null || arr.Length == 0) return false;
            foreach (var t in arr)
                if (t == '1')
                    return true;

            return false;
        }

        public int GetPostIndex(int index, char[] chars)
        {
            return chars.Length - 1 - index;
        }

        public char GetPostChar(int i, char[] chars)
        {
            if (i >= chars.Length) return '0';
            return chars[GetPostIndex(i, chars)];
        }

        public int GetPostIndex(int index, string str)
        {
            return str.Length - 1 - index;
        }
    }
}