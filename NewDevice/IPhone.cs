using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestDll;

namespace NewDevice
{
    /// <summary>
    /// iPhone类
    /// </summary>
    public class IPhone : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("iPhone读数据");
        }

        public override void Write()
        {
            Console.WriteLine("iPhone写数据..");
        }
    }
}
