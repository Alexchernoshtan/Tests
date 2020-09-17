using System;
using System.Collections.Generic;
using System.Text;
using Generator;

namespace Generator
{
    class Device 
    {
        public Device Parent { get; set; } // Abstraction

        public Device Child { get; set; }

        public string Name { get; set; }

        public int ConsumptionPower { get; set; }

        public int LeftPower { get; set; }

        

        public Device(string name, int power)
        {
            this.Name = name;
            this.ConsumptionPower = power;
        }
    }
}
