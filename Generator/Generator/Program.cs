using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography.X509Certificates;
namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Generator generator = new Generator(100);
            Device mac = new Device("Macbook",45);
            Device mouse = new Device("mouse", 23);
            Device keyboard = new Device("keyboard", 37);
            Device tv = new Device("tv", 84);
            Device phone = new Device("phone", 13);
            Device printer = new Device("printer", 24);
            generator.Alldevices(mac, mouse, keyboard, tv, phone, printer);
            var all = generator.alldevices;
           
            



            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Мощность генератора : 100"+"\n");
            foreach (Device d in generator.alldevices)
            {
                Console.WriteLine("Доступные устройства: "+d.name+" - мощность "+d.power+ "\n");
            }
            

            Console.WriteLine("Соединить два устройства между собой и подключить : 1");
            Console.WriteLine("Подключить устройство к генератору : 2");
            Console.WriteLine("Отключить устройство от генератора : 3");

            int x1 = Convert.ToInt16(Console.ReadLine());
       
                switch (x1)
                {
                    case 1:
                        Console.WriteLine("Выберите два устройства" + "\t" + "Доступные устройства : Macbook -  0 ,Mouse - 1,Keyboard - 2,TV - 3,Phone - 4,Printer - 5");
                        int x2 = Convert.ToInt16(Console.ReadLine());
                        int x3 = Convert.ToInt16(Console.ReadLine());
                        generator.PairOfDevices(all[x2], all[x3]);
                        generator.Output();
                        goto case 2;

                    case 2:
                        Console.WriteLine("Macbook : 1, Mouse :2, Keyboard : 3, TV :4 , Phone : 5 , Printer : 6");
                        int x4 = Convert.ToInt16(Console.ReadLine());
                        switch (x4)
                        {
                            case 1:
                                generator.AddDevice(mac);
                                generator.Output();
                                break;
                            case 2:
                                generator.AddDevice(mouse);
                                generator.Output();
                                break;
                            case 3:
                                generator.AddDevice(keyboard);
                                generator.Output();
                                break;
                            case 4:
                                generator.AddDevice(tv);
                                generator.Output();
                                break;
                            case 5:
                                generator.AddDevice(phone);
                                generator.Output();
                                break;
                            case 6:
                                generator.AddDevice(printer);
                                generator.Output();
                                break;

                        }

                        goto case 3;
                    case 3:
                        var gen = generator.devices;
                        Random rnd = new Random();
                        int value = rnd.Next(0, generator.devices.Count - 1);
                        Console.WriteLine("Отключаем устройство " + gen[value].name);
                        generator.DisconnectDevice(gen[value]);
                        generator.Output();

                        break;
                   
            }
            

            
        }
    }
}
