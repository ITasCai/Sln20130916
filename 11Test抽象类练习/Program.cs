using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestDll;
using NewDevice;

namespace _11Test抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            UDisk u = new UDisk();
            MP3 mp3 = new MP3();
            MobileHardDisk hd = new MobileHardDisk();
            IPhone iphone = new IPhone();
            Computer computer = new Computer();
            computer.Device = mp3;//iphone;//hd;//mp3;//u;

            computer.ReadData();
            computer.WriteData();
            Console.ReadKey();
        }
    }
}
