using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05虚方法练习
{
    class Program
    {
        static void Main(string[] args)
        {

            //实现多态的手段有很多，虚方法只是其中之一。
            Person p = new Driver(); //new Teacher(); //new Student();
            p.SayHello();
            Console.ReadKey();
        }
    }

    public class Person
    {
        public virtual void SayHello()
        {
            Console.WriteLine("我是学生");
        }
    }

    public class Student : Person
    {
        //学生类不需要重写SayHello()方法
    }

    public class Teacher : Person
    {
        public override void SayHello()
        {
            Console.WriteLine("我是老师");
        }
    }

    public class Driver : Person
    {
        public override void SayHello()
        {
            Console.WriteLine("我是司机。");
        }
    }
}
