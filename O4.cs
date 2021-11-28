using System;
using System.Collections.Generic;
using System.Diagnostics;
using static LeetCodeSolutions.Tools;
namespace LeetCodeSolutions
{
    /// <summary>
    /// 研究数组底层
    /// </summary>
    public class O4
    {
        class MyClass
        {
            private int num;
            static int copyTimes = 0;

            public MyClass(int n)
            {
                num = n;
            }
            public MyClass(in MyClass c)
            {
                copyTimes++;
                Console.WriteLine(copyTimes);
                num = c.num;
            }
        }
        public static void ListTest()
        {
            List<MyClass> list = new List<MyClass>(1);
            list.Add(new MyClass(1));
            list.Add(new MyClass(2));
            list.Add(new MyClass(3));
            list.Add(new MyClass(3));
            list.Add(new MyClass(3));
            list.Add(new MyClass(3));
            list.Add(new MyClass(3));
            list.Add(new MyClass(3));
            list.Add(new MyClass(3));
            list.Add(new MyClass(3));
            list.Add(new MyClass(3));
        }
    }
}