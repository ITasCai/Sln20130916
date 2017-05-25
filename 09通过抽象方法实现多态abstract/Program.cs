using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09通过抽象方法实现多态abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new American(); //new Chinese();
            //p.Show();
            //Console.ReadKey();

            // Person p = new Person();

            Person p = new American();//new Chinese();
            p.Show();
            p.SayHi();
            Console.ReadKey();

        }
    }



    #region 使用抽象方法abstract来实现多态

    public abstract class Person
    {
        public static string Email;

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //1>使用abstract关键字标记方法
        //2>抽象方法在父类中不能有任何实现，所以抽象方法没有方法体。
        //3>抽象成员必须写在抽象类中。
        //4>抽象类是不能被实例化的。不能直接new一个抽象类的对象。
        //5>抽象类中既可以有抽象成员，也可以有实例成员。
        //6>抽象成员不能是私有的。 
        //7>子类继承抽象类后，对于抽象类中的抽象成员子类必须重写（因为父类中没有默认实现），除非子类也标记为abstract。
        public abstract void Show();
        public abstract void SayHi();
    }
    //子类继承Person类
    public class Chinese : Person
    {

        public override void Show()
        {
            Console.WriteLine("Show in Chinese");
        }

        public override void SayHi()
        {
            Console.WriteLine("SayHi in Chinese.");
        }
    }

    public class American : Person
    {

        public override void Show()
        {
            Console.WriteLine("Show in American");
        }

        public override void SayHi()
        {
            Console.WriteLine("SayHi in American");
        }
    }

    #endregion



    #region 使用虚方法实现多态


    //public class Person
    //{
    //    public virtual void Show()
    //    {
    //        Console.WriteLine("Show in Person");
    //    }
    //}

    //public class Chinese : Person
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("Show in Chinese");
    //    }
    //}

    //public class American : Person
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("Show in American");
    //    }
    //}

    #endregion


}
