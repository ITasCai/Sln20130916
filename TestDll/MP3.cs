using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDll
{
    /// <summary>
    /// MP3类
    /// </summary>
    public class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3读数据。。。。");
        }

        public override void Write()
        {
            Console.WriteLine("MP3写数据.....");
            //PlayMusic();

        }

        public void PlayMusic()
        {
            Console.WriteLine("MP3播放音乐.....");
        }
    }
}
