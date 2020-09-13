using System;
using System.Collections.Generic;
using System.Text;
using Generator;

namespace Generator
{
    class Device 
    {    
        public string name { get; set; }
        public int power { get; set; }
        public bool ispairing { get; set; }
        public Device(string name, int power)
        {
            this.name = name;
            this.power = power;
        }
        public Device()
        {
        }
    }
}
