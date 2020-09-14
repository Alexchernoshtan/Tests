using System;

namespace Generator {
    class Generator : Object {
        // SOLID
        public int Power { get; }

        public Device Child { get; set; }

        public Generator(int power) {
            this.Power = power;
        }

        internal void Plug(Device d1) {
            Child = d1;
            d1.Parent = this;

            System.Console.WriteLine();
        }

        internal void Unplug() {
            //TODO
        }
    }
}
