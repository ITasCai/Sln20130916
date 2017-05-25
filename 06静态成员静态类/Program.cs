using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06静态成员静态类
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Person.LivePlanet = "地球";

            ////静态内容在内存中只存储一份
            //Person.LivePlanet = "火星";


            //Person p1 = new Person();
            //p1.Name = "张三";//而实例成员每次创建一个对象，就存储一份内容



            //Person p2 = new Person();
            //p1.Name = "李四";

            ////静态成员，不能通过对象访问，只能通过类名直接访问。
            ////所有对象共享的信息可以在实例类中加一个静态成员来表示，对于那些每个对象都需要保存个字的信息时，就需要创建实例成员来保存不同对象的信息了。
            ////静态成员，在整个应用程序中任何一个地方都可以访问的到，所以静态成员直到程序退出后才会释放内存。而实例成员，当没有变量使用后就可以被垃圾回收了，回收后内存就释放了。【可以把一些常用的工具函数，封装到一个静态类中，使用方便】
            //Console.WriteLine(Person.LivePlanet);


            TestStaticClass.SayHi();
            TestStaticClass.Name = "长孙娜";
            Console.ReadKey();



        }
    }

    public class Person
    {

        public static void SayHi()
        {
            Person p = new Person();
            p.Name = "你好1！！";

            //this.Name;//出错！！！！！，不能在静态成员中直接访问实例成员。
        }


        public string Name
        {
            get;
            set;
        }


        public int Age
        {
            get;
            set;
        }

        public string Phone
        {
            get;
            set;
        }

        /// <summary>
        /// 所生活的星球
        /// </summary>
        public static string LivePlanet
        {
            get;
            set;
        }
    }

    //在静态类中只能有静态成员，不能有实例成员
    //静态类不能创建对象，不能new对象。
    //什么时候用静态类：
    //1>在整个应用程序中要共享某些数据的时候可以使用静态类。
    //2>静态类不能创建对象，使用的时候直接通过类名来操作成员，（使用方便），所以说对于那些类中包含有大量的方法，并且类不需要创建对象的时候，可以使用静态类。
    public static class MyStaticClass
    {
        public static string Name
        {
            get;
            set;
        }

        public static void SayHi()
        {
            Console.WriteLine("hi!!!!");
        }
    }
}
