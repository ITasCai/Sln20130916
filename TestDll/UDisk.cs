using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDll
{



    /// <summary>
    /// u盘类
    /// </summary>
    public class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘读数据...");
        }

        public override void Write()
        {
            Console.WriteLine("U盘写数据...");

            //......
            //...............
        }

        //public override string ToString()
        //{
        //    return "U盘";
        //}
    }
}
