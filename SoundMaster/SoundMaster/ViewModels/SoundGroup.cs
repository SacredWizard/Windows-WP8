﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundMaster.ViewModels
{
    public class SoundGroup
    {
        public SoundGroup()
        {
            Items = new List<SoundData>(); 
        }
        public List<SoundData> Items { get; set; }
        public string Title { get; set; }
    }
}
