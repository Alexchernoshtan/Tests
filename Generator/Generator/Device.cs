using System;
using System.Collections.Generic;

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
        public static void ConnectDevice(Device d1, List<Device> devices, Generator generator)
        {
            int pow = 0;
            foreach (Device d in devices)
            {
                pow += d.ConsumptionPower;
            }

            if (generator.Power > pow + d1.ConsumptionPower)
            {

                devices.Add(d1);

                if (devices.Count > 1)
                {
                    devices[0].Parent = null;
                    devices[0].Child = devices[1];
                    devices[devices.Count - 1].Parent = devices[devices.Count - 2];
                    devices[devices.Count - 1].Child = null;
                    for (int i = 1; i < devices.Count - 2; i++)
                    {
                        devices[i].Parent = devices[i + 1];
                        devices[i].Child = devices[i - 1];
                    }
                }
            }
            else
            {
                Console.WriteLine("No power");
            }

        }
        public static void DisconnectDevice(int from, List<Device> devices)
        {
            devices.RemoveRange(from, devices.Count - from);
        }
    }
}
