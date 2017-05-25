using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08里氏替换类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new American(); //new Chinese();


            ////Chinese cn = (Chinese)p;


            //Person p = new ShiJiaZhuangRen();
            //QinHuangDaoRen qhd = (QinHuangDaoRen)p;
            //Console.WriteLine("ok");
            //Console.ReadKey();

            Person p = new ShiJiaZhuangRen();

            //if (p is Chinese)
            //{
            //    //类型转换，最好在转换前做判断。否则如果转换失败则报异常
            //    Chinese qhd = (Chinese)p;
            //}

            //另外一种类型转换,以下使用as的这种数据类型转换如果转换成功则把转换后的结果赋值给c变量，如果转换失败则给c变量赋值一个null值。即便转换失败也不会报异常。
            American c = p as American;//推荐使用这种方式。

            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }

    class Person
    {

    }

    class Chinese : Person
    {

    }

    class American : Person
    {

    }

    class HeBeiRen : Chinese
    {

    }

    class ShiJiaZhuangRen : HeBeiRen
    {

    }
    class QinHuangDaoRen : HeBeiRen
    {

    }

    class JiaLiFuNiYaRen : American
    {

    }
}
