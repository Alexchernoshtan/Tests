using System;
using System.Collections.Generic;
namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            LinkedList<Device> devices = new LinkedList<Device>();
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
                int pow = 0;
                foreach(Device d in devices)
                {
                    pow += d.ConsumptionPower;
                }
                switch (x1)
                {
                    case 1:
                        if (generator.Power > pow + mac.ConsumptionPower)
                        {
                            Device.ConnectDevice(mac, devices);
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно мощности");
                        }
                        break;
                    case 2:
                        if (generator.Power > pow + mouse.ConsumptionPower)
                        {
                            Device.ConnectDevice(mouse, devices);
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно мощности");
                        }
                        break;
                    case 3:
                        if (generator.Power > pow + keyboard.ConsumptionPower)
                        {
                            Device.ConnectDevice(keyboard, devices);
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно мощности");
                        }
                        break;
                    case 4:
                        if (generator.Power > pow + tv.ConsumptionPower)
                        {
                            Device.ConnectDevice(tv, devices);
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно мощности");
                        }
                        break;
                    case 5:
                        if (generator.Power > pow + phone.ConsumptionPower)
                        {
                            Device.ConnectDevice(phone, devices);
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно мощности");
                        }
                        break;
                    case 6:
                        if (generator.Power > pow + printer.ConsumptionPower)
                        {
                            Device.ConnectDevice(printer, devices);
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно мощности");
                        }
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }

            ConsoleOutput(devices);
            Console.WriteLine("Выберите какое устройство отлючить:");
            int x2 = Convert.ToInt16(Console.ReadLine());
            Device.DisconnectDevice(x2, devices);
            ConsoleOutput(devices);
        }      
        
        static void ConsoleOutput(LinkedList<Device> devices)
        {
            Console.WriteLine("Подключённые устройства:");
            var item = devices.First;
            int i = 1;
            while (item != null)
            {

                if(item.Value.Parent == null  )
                {
                    Console.Write(item.Value.Name + " | Мощность : " + item.Value.ConsumptionPower + '\t' + " | Child: " + item.Value.Child.Name + "|  Parent: Generator"  +" | Input 1" + '\n');
                   
                }
                else if(item.Value.Child == null)
                {
                    Console.Write(item.Value.Name + "| Мощность : " + item.Value.ConsumptionPower + '\t' + " | Child: None Parent: " + item.Value.Parent.Name  +" | Input "+ devices.Count + '\n');
                }
                else
                {
                    Console.Write(item.Value.Name + "| Мощность : " + item.Value.ConsumptionPower + '\t' + " | Child: "+item.Value.Child.Name +"|  Parent: "+ item.Value.Parent.Name +"|  Input "+i + '\n');
                }
                i++;
                item = item.Next;
            }
        }
    }
}
