using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SeasOfWrath
{
    public class Save
    {
        public int Xpos { set; get; }
        public int Ypos { set; get; }
        public int Health { set; get; } 
        public int Food { set; get; }
        public int Level { set; get; }
    }
}
