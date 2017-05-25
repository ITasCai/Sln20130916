using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01访问修饰符
{
    class Class1
    {

        public void My()
        {
            MyClassTestInternal mcti = new MyClassTestInternal();
            // mcti.SayHi
        }
    }
}
