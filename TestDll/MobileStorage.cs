using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDll
{
    /// <summary>
    /// 可移动存储设备
    /// </summary>
    public abstract class MobileStorage
    {
        public abstract void Read();


        public abstract void Write();
    }
}
