using System;

namespace LeetCode
{
    public class Singleton
    {
        // 私有构造函数，防止外部实例化
        private Singleton()
        {
            Console.WriteLine("Singleton instance created.");
        }

        // 公共访问点，用于获取单例实例
        public static Singleton Instance => SingletonHolder.Instance;

        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }

        // 静态内部类，负责实例的创建
        private static class SingletonHolder
        {
            // 静态初始化器，CLR 会确保线程安全
            internal static readonly Singleton Instance = new Singleton();
        }
    }
}