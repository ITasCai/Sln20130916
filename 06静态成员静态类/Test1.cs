using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06静态成员静态类
{

    public class Test1
    {
        public Test1()
        {

        }

        public static int Age = 100;

        public string Name
        {
            get;
            set;
        }
    }

    public static class TestStaticClass
    {


        public static string Name;

        public static void SayHi()
        {
            Console.WriteLine("Hi~~~");
        }


        //1.静态构造函数特点：
        //1>必须使用static关键字修饰。
        //2>静态构造函数的函数名与类名一致。
        //3>静态构造函数没有访问修饰符。
        //4>静态构造函数不能有参数，也不能重载。
        //5>何时调用静态构造函数？在第一次使用该静态类之前，调用一次构造函数（静态构造函数只会被调用一次。）

        /// <summary>
        /// 类的静态构造函数
        /// </summary>
        static TestStaticClass()
        {
            Console.WriteLine("静态构造函数被调用了！！！！");
        }
    }
}
