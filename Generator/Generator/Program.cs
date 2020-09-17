using System;
using System.Collections.Generic;
namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            List<Device> devices = new List<Device>();
            Generator generator = new Generator(100);
            Device mac = new Device("Macbook", 2);
            Device mouse = new Device("Mouse", 23);
            Device keyboard = new Device("Keyboard", 37);
            Device tv = new Device("TV", 84);
            Device phone = new Device("Phone", 13);
            Device printer = new Device("Printer", 24);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Выберите устройства для подключений");
            while (flag)
            {
                Console.WriteLine("Macbook : 1, Mouse :2, Keyboard : 3, TV :4 , Phone : 5 , Printer : 6, Отключить цепочку устройств - 7");
                int x1 = Convert.ToInt16(Console.ReadLine());
                switch (x1)
                {
                    case 1:
                        ConnectDevice(mac, devices, generator);
                        break;
                    case 2:
                        ConnectDevice(mouse, devices, generator);
                        break;
                    case 3:
                        ConnectDevice(keyboard, devices, generator);
                        break;
                    case 4:
                        ConnectDevice(tv, devices, generator);
                        break;
                    case 5:
                        ConnectDevice(phone, devices, generator);
                        break;
                    case 6:
                        ConnectDevice(printer, devices, generator);
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
           
            ConsoleOutput(devices);
            Console.WriteLine("Выберите какое устройство отлючить:");
            int x2 = Convert.ToInt16(Console.ReadLine());
            DisconnectDevice(x2,devices);
            ConsoleOutput(devices);

        }
        static void ConnectDevice(Device d1, List<Device> devices, Generator generator)
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
        static void DisconnectDevice(int from, List<Device> devices)
        {
            devices.RemoveRange(from, devices.Count-from );
        }
        static void ConsoleOutput(List<Device> devices)
        {
            Console.WriteLine("Подключённые устройства:");
            foreach (Device d in devices)
            {
                if (d.Parent == null)
                {
                    Console.WriteLine(d.Name + ":" + '\n' + " Мощность -" + d.ConsumptionPower + '\n' + " Parent - generator" + " Click 0");
                }
                else
                {
                    Console.WriteLine(d.Name + ":" + '\n' + " Мощность -" + d.ConsumptionPower + '\n' + "Parent-" + d.Parent.Name + " Click : " + devices.IndexOf(d));
                }

            }
        }
    }
}
