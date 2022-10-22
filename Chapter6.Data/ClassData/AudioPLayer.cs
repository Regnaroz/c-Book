﻿using Chapter6.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.Data.ClassData
{
    public class AudioPLayer : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("Audio Is Paused ! ");
        }

        public void PLay()
        {
            Console.WriteLine("Audio Is Playing ! ");
        }
    }
}
