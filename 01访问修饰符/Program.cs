using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#中的访问修饰符：
            //private,私有访问修饰符，被private访问修饰符修饰的成员只有在当前类的内部可以访问，其他地方一律不能访问【类中成员，如果不写访问修饰符则默认都是私有的】
            //protected,表示当前类内部可以访问并且所有的子类内部也可以访问。

            //注意：protected与internal访问修饰符无所谓哪个更“可访问”，因为判断标准不一样
            //protected只看是否是在当前类内部或者所有的子类内部，与是否在同一个程序集中无关
            //internal只看是否在同一个程序集中，与是否具有继承关系无关。
            //internal,当前程序集内部可以随便访问，超出当前程序集则无法访问。


            //这个访问修饰符兼具protected与internal的特性，在两种情况下都可以访问。
            //protected internal,当前类内部，所有子类内部，当前程序集内部。


            //没有限制，任何地方都可以访问的到。
            //public

            //MyClass_Sub mcsub = new MyClass_Sub();
            ////mcsub.

            //MyClass mc = new MyClass();
            //// mc.M1();

            //// mc.M1();
            //Console.Read();

            Class2 c2 = new Class2();
            //c2.SayHi();
          


        }
    }

    public class MyClassTestInternal
    {
        public void SayHi()
        {
            Console.WriteLine("Hi~~我是public");
        }

        internal void SayHello()
        {
            Console.WriteLine("Hello,我是internal");
        }
    }




    //类的默认访问修饰符是internal
    public class MyClass
    {

        string _name;

        void Hello()
        {

        }

        protected string _email;


        private int _age;

        private void M1()
        {
            Console.WriteLine("M1");
        }


        public void Say()
        {
            //_age
            this.M1();
        }

        protected string _address;
    }

    class MyClass_Sub : MyClass
    {

        public void MM()
        {
            //this.
        }
    }



    //所有在命名空间中直接定义的类型，比如类、委托、枚举、结构、。。。。的访问修饰符只能是public或internal
}
