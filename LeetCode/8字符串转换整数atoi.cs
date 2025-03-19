using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _8字符串转换整数atoi
    {
        public class Solution
        {
            public int MyAtoi(string s)
            {
                Stack<int> stack = new Stack<int>();
                for (int i = 0; i < s.Length; i++)
                {
                    bool isBreak = false;
                    var c = s[i];
                    switch (c)
                    {
                        case '0':
                            if (stack.Count == 0)
                            {
                                stack.Push(1);
                            }

                            stack.Push(0);
                            break;
                        case '1':
                            if (stack.Count == 0)
                            {
                                stack.Push(1);
                            }

                            stack.Push(1);
                            break;
                        case '2':
                            if (stack.Count == 0)
                            {
                                stack.Push(1);
                            }

                            stack.Push(2);
                            break;
                        case '3':
                            if (stack.Count == 0)
                            {
                                stack.Push(1);
                            }

                            stack.Push(3);
                            break;
                        case '4':
                            if (stack.Count == 0)
                            {
                                stack.Push(1);
                            }

                            stack.Push(4);
                            break;
                        case '5':
                            if (stack.Count == 0)
                            {
                                stack.Push(1);
                            }

                            stack.Push(5);
                            break;
                        case '6':
                            if (stack.Count == 0)
                            {
                                stack.Push(1);
                            }

                            stack.Push(6);
                            break;
                        case '7':
                            if (stack.Count == 0)
                            {
                                stack.Push(1);
                            }

                            stack.Push(7);
                            break;
                        case '8':
                            if (stack.Count == 0)
                            {
                                stack.Push(1);
                            }

                            stack.Push(8);
                            break;
                        case '9':
                            if (stack.Count == 0)
                            {
                                stack.Push(1);
                            }

                            stack.Push(9);
                            break;
                        case '+':
                            if (stack.Count > 0)
                            {
                                isBreak = true;
                            }
                            else
                            {
                                stack.Push(1);
                            }

                            break;
                        case '-':
                            if (stack.Count > 0)
                            {
                                isBreak = true;
                            }
                            else
                            {
                                stack.Push(-1);
                            }

                            break;
                        case ' ':
                            if (stack.Count > 0)
                            {
                                isBreak = true;
                            }

                            break;
                        default:
                            isBreak = true;
                            break;
                    }

                    if (isBreak)
                    {
                        break;
                    }
                }

                var res = 0;
                var byteI = 0;
                while (stack.Count > 0)
                {
                    if (stack.Count == 1)
                    {
                        var lastByte = stack.Pop();
                        if (lastByte == 1)
                        {
                            if (res <= int.MinValue + 1)
                            {
                                return int.MaxValue;
                            }
                            else
                            {
                                return -res;
                            }
                        }
                        else
                        {
                            return res;
                        }
                    }
                    else
                    {
                        var tmp = stack.Pop();
                        if (tmp != 0)
                        {
                            if (byteI == 0)
                            {
                                tmp = tmp;
                            }
                            else if (byteI < 9)
                            {
                                tmp = tmp * (int)(Math.Pow(10, byteI));
                            }
                            else if (byteI == 9 &&tmp <3)
                            {
                                tmp = tmp * (int)(Math.Pow(10, byteI));
                            }
                            else
                            {
                                tmp = int.MinValue;
                            }
                        }

                        

                        if (res < int.MinValue + tmp)
                        {
                            res = int.MinValue;
                        }
                        else
                        {
                            res -= tmp;
                        }
                    }
                    byteI++;
                }
                return res;
            }
        }
    }
}