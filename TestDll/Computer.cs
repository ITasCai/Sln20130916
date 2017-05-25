using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDll
{
    public class Computer
    {

        /// <summary>
        /// 设备，将来把其他的可移动存储设备赋值给该属性
        /// 就是表示将对应的可移动存储设备插到了计算机上。
        /// </summary>
        public MobileStorage Device
        {
            get;
            set;
        }


        public void ReadData()
        {
            if (Device!=null)
            {
                Device.Read();
            }
        }


        public void WriteData()
        {
            if (Device!=null)
            {
                Device.Write();
            }
        }
    }
}
