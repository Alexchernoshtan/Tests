using System.Collections.Generic;

namespace Generator
{
    class Device
    {
        public Device Parent { get; set; }
        public Device Child { get; set; }
        public string Name { get; set; }
        public int ConsumptionPower { get; set; }
        public Device(string name, int power)
        {
            this.Name = name;
            this.ConsumptionPower = power;
        }

        public static void ConnectDevice(Device d1, LinkedList<Device> devices)
        {
            devices.AddLast(d1);
            if (devices.Count > 1)
            {
                devices.First.Value.Parent = null;
                devices.First.Value.Child = devices.First.Next.Value;
                devices.Last.Value.Parent = devices.Last.Previous.Value;
                devices.Last.Value.Child = null;
                var item = devices.First.Next;
                while (item != devices.Last)
                {
                    item.Value.Parent = item.Previous.Value;
                    item.Value.Child = item.Next.Value;
                    item = item.Next;
                }
            }
        }
        public static void DisconnectDevice(int from, LinkedList<Device> devices)
        {
            while (devices.Count >= from)
            {
                devices.RemoveLast();
            }
        }
    }
}
