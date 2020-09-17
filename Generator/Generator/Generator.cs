using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Generator
{
    class Generator
    {
        public int Power { get; }

        public  Device Child { get; set; }

        public Generator(int power)
        {
            this.Power = power;
        }

        internal void Plug(Device d1)
        {
            Child = d1;
            //d1.Parent =;

            System.Console.WriteLine();
        }

        internal void Unplug()
        {
            //TODO
        }
    }
    
}
