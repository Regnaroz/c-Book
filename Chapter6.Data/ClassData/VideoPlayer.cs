using Chapter6.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.Data.ClassData
{
    public class VideoPlayer : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("Video Is Paused !");
        }

        public void PLay()
        {
            Console.WriteLine("Video Is Playing !");
        }
    }
}
