using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDll
{
    /// <summary>
    /// 移动硬盘类
    /// </summary>
    public class MobileHardDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘读数据....");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘写数据....");
        }
    }
}
