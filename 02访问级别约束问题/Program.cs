using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02访问级别约束问题
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //class Parent
    //{
    //    internal string Name
    //    {
    //        get;
    //        set;
    //    }
    //}
    //子类的访问修饰符必须与父类的访问修饰符兼容。
    //class Child : Parent
    //{

    //}


    //class MyClass
    //{

    //}

    //public class MyClass1
    //{

    //    //方法的参数的访问修饰符必须与方法的访问修饰符兼容。
    //    public void M1(MyClass mc)
    //    {
    //        Console.WriteLine(mc.ToString());
    //    }
    //}

    //public class MyClass
    //{

    //}

    //public class MyClass1
    //{
    //    private void Say(MyClass mc)
    //    {

    //    }
    //}


    //class MyClass
    //{
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }


    //    public string get_name()
    //    {

    //    }
    //    public void set_name(string value)
    //    {

    //    }
    //}

    ////如果类MyClass1的访问修饰符也是internal的，则不报错。
    ////如果把该类的访问修饰符改为public则 报错。
    //class MyClass1
    //{

    //    //方法的返回值的类型的访问修饰符必须与方法的访问修饰符兼容。
    //    public MyClass M1()
    //    {
    //        Console.WriteLine("ok");
    //        return null;
    //    }
    //}



    //class MyClass
    //{

    //}

    //public class Person
    //{

    //    public MyClass MC
    //    {
    //        get;
    //        set;
    //    }
    //}
}
