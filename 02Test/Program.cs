using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _01访问修饰符;

namespace _02Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClassTestInternal mcti = new MyClassTestInternal();
            //mcti.sa

            //Class2 c2 = new Class2();



        }
    }
    class MyClass1111 : Class2
    {
        public MyClass1111()
        {
            this.SayHi();
        }
    }

    class Test : MyClass
    {
        public void X()
        {
            //this._address
        }
    }
}
