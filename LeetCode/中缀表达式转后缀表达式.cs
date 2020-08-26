using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class 中缀表达式转后缀表达式
    {
        Dictionary<char, int> m_ops = new Dictionary<char, int>()
        {
            ['+'] = 1,
            ['-'] = 1,
            ['/'] = 2,
            ['*'] = 2,
            ['('] = 0,
            [')'] = 3,
        };
        Stack<char> m_st = new Stack<char>();

        private void InsertOpt(char c)
        {
            if (m_st.Count == 0)
            {
                m_st.Push(c);
                return;
            }
            if (c == '(')
            {
                m_st.Push(c);
                return;
            }
            if (c == ')')
            {
                var next = m_st.Pop();
                if (next == '(')
                    return;
                Console.Write(next);
                InsertOpt(c);
                return;
            }
            if (m_ops[c] > m_ops[m_st.Peek()])
            {
                m_st.Push(c);
                return;
            }
            Console.Write(m_st.Pop());
            InsertOpt(c);
        }
        public void Translate(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!m_ops.ContainsKey(c))
                {
                    Console.Write(c);
                    continue;
                }
                InsertOpt(c);
            }
            while (m_st.Count > 0)
            {
                Console.Write(m_st.Pop());
            }
        }
    }
}
