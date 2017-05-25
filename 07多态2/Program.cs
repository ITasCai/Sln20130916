using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _07多态2
{
    class Program
    {
        static void Main(string[] args)
        {
            //object obj = new object();
            //Console.WriteLine(obj.ToString());
            //Console.ReadKey();

            //Person p = new Person();
            //Console.WriteLine(p.ToString());
            //Console.ReadKey();

            //FileStream fs = new FileStream("aaa", FileMode.Append);
            //Console.WriteLine(fs.ToString());
            //Console.ReadKey();

            //string[] names = new string[] { "aaa", "bbbb", "cccc" };
            //Console.WriteLine(names.ToString());
            //Console.ReadKey();



            //string a = new string(new char[] { 'a', 'b', 'c' });
            //Console.WriteLine(a.ToString());


            int n = 100;
            Console.WriteLine(n.ToString());

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
