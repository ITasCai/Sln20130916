using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03多态
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 通过虚方法实现多态


            //Person[] people = new Person[6];

            //Chinese cn1 = new Chinese();
            //Chinese cn2 = new Chinese();
            //British br1 = new British();
            //British br2 = new British();
            //Japanese jp1 = new Japanese();
            //American am1 = new American();
            //people[0] = cn1;
            //people[1] = cn2;
            //people[2] = br1;
            //people[3] = br2;
            //people[4] = jp1;
            //people[5] = am1;


            ////开放封闭原则：对扩展开放，对修改封闭。
            //for (int i = 0; i < people.Length; i++)
            //{
            //    //因为Person类型中没有Show方法所以无法直接通过Person类型调用Show()方法。
            //    // people[i].Show();


            //    #region 判断对象类型，进行转换，然后调用不同的方法。
            //    ////Chinese cn = (Chinese)people[i];
            //    ////cn.Show();

            //    //if (people[i] is Chinese)
            //    //{
            //    //    Chinese cn = (Chinese)people[i];
            //    //    cn.Show();
            //    //}
            //    //else if (people[i] is British)
            //    //{
            //    //    British uk = (British)people[i];
            //    //    uk.Show();
            //    //}
            //    //else if (people[i] is Japanese)
            //    //{
            //    //    Japanese jp = (Japanese)people[i];
            //    //    jp.Show();
            //    //}
            //    #endregion

            //    //这句话体现了多态。。。。
            //    people[i].Show();


            //}
            //Console.ReadKey();

            #endregion

            //Person p = new American();//new Chinese();
            //p.Show();
            //Console.ReadKey();

            ////Console.Write();

            ////Convert.

            //    //Math.
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Height { get; set; }

        //虚方法特点总结：
        //1.在父类中把需要设置为虚方法的方法前加virtual标记。
        //2.虚方法在父类中必须有实现。
        //3.子类继承父类后，可以选择对虚方法进行重写也可以选择不重写。
        //4.当子类重写父类中的方法的时候，必须保证重写后的方法与原方法的访问修饰符、返回值类型、方法名、参数列表完全一致。
        //5.当方法的标记是virtual或者override的时候都可以重写。




        //在Person类型中增加一个Show()方法。
        //第一步：将父类中的Show方法标记为virtual（虚方法）
        public virtual void Show()
        {
            //Console.WriteLine("Person 中的 Show方法。");
        }


    }

    //高丽
    public class Korean : Person
    {
        public override void Show()
        {
            Console.WriteLine("我是高丽人");
        }
    }

    /// <summary>
    /// 朝鲜
    /// </summary>
    public class NorthKorean : Korean
    {
        public override void Show()
        {
            Console.WriteLine("我是朝鲜人！！！！");
        }
    }



    public class American : Person
    {
        //当进行方法重写的时候，必须使用override关键字。
        public override void Show()
        {
            Console.WriteLine("我是美国人！");
        }
    }

    /// <summary>
    /// 中国人类
    /// </summary>
    public class Chinese : Person
    {
        //重写父类中的方法（覆盖）override
        public override void Show()
        {
            Console.WriteLine("我是中国人");
        }
    }


    /// <summary>
    /// 英国人类
    /// </summary>
    public class British : Person
    {
        public override void Show()
        {
            Console.WriteLine("我是英国人");
        }
    }

    /// <summary>
    /// 日本人类
    /// </summary>
    public class Japanese : Person
    {
        public override void Show()
        {
            Console.WriteLine("我是日本人");
        }
    }
}
