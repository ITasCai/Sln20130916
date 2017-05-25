using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10抽象方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Dog(); //new Cat();


            //animal.Eat();
            //animal.Bark();
            //Console.ReadKey();


            Shape shape = new Rectangle(10, 20); //new Square(10); //new Circle(10);
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetGirth());
            Console.ReadKey();
        }
    }

    public abstract class Person
    {
        public abstract void SayHello();


        public abstract void Standup();
    }

    public class Teacher : Person
    {

        public override void SayHello()
        {
            Console.WriteLine("同学们好！！");
        }

        public override void Standup()
        {
            Console.WriteLine("起立！");
        }
    }

    public class Student : Person
    {

        public override void SayHello()
        {
            Console.WriteLine("老师早上好！");
        }

        public override void Standup()
        {
            Console.WriteLine("同学们请起立！");
        }
    }




    /// <summary>
    /// 形状父类，抽象类
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// 面积
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();

        /// <summary>
        /// 周长
        /// </summary>
        /// <returns></returns>
        public abstract double GetGirth();
    }
    //圆形
    public class Circle : Shape
    {
        /// <summary>
        /// 构造函数为半径赋值
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// 半径
        /// </summary>
        public double Radius
        {
            get;
            set;
        }

        /// <summary>
        /// 计算面积
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        /// <summary>
        /// 计算周长
        /// </summary>
        /// <returns></returns>
        public override double GetGirth()
        {
            return 2 * Math.PI * this.Radius;
        }
    }


    //正方形
    public class Square : Shape
    {
        public Square(double side)
        {
            this.SideLength = side;
        }

        public double SideLength
        {
            get;
            set;
        }

        public override double GetArea()
        {
            return this.SideLength * this.SideLength;
        }

        public override double GetGirth()
        {
            return this.SideLength * 4;
        }
    }

    //长方形
    public class Rectangle : Shape
    {
        public Rectangle(double h, double w)
        {
            this.Height = h;
            this.Width = w;
        }
        public double Height
        {
            get;
            set;
        }

        public double Width
        {
            get;
            set;
        }

        public override double GetArea()
        {
            return this.Width * this.Height;
        }

        public override double GetGirth()
        {
            return 2 * (this.Height + this.Width);
        }
    }







    public abstract class Animal
    {
        public abstract void Eat();

        public abstract void Bark();
    }

    public class Dog : Animal
    {

        public override void Eat()
        {
            Console.WriteLine("狗啃骨头！ ");
        }

        public override void Bark()
        {
            Console.WriteLine("汪汪汪嗷嗷嗷叫！！");
        }
    }

    public class Cat : Animal
    {

        public override void Eat()
        {
            Console.WriteLine("猫吃鱼。。。");
        }

        public override void Bark()
        {
            Console.WriteLine("喵喵叫！");
        }
    }
}
