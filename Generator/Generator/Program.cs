﻿using System;
using System.Collections.Generic;

namespace Generator {
    class Program {
        public struct Point : Object {
            // TODO Learn
        }

        public struct Point2 : Point {
            // TODO Learn
        }

        static void Main(string[] args) {
            List<int> l = null;

            Dictionary<int, int> keyValuePairs = null; // GetHasCode // Equals - Polymorpism
            HashSet<int> hs;

            int[] a = null;
            Queue<int> q;
            Stack<int> s;
            LinkedList<int> ll;

            //c# reference types vs value types

            var gen = new Generator(1000);
            var d1 = new Device("1", 100);
            var d2 = new Device("2", 100);
            var d3 = new Device("3", 100);

            gen.Plug(d1);
            gen.Unplug();

            Generator generator = new Generator(100);
            Device mac = new Device("Macbook", 45);
            Device mouse = new Device("mouse", 23);
            Device keyboard = new Device("keyboard", 37);
            Device tv = new Device("tv", 84);
            Device phone = new Device("phone", 13);
            Device printer = new Device("printer", 24);
            generator.AddAlldevices(mac, mouse, keyboard, tv, phone, printer);
            var all = generator.Alldevices;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Мощность генератора : 100" + "\n");
            foreach (Device d in generator.Alldevices) {
                Console.WriteLine("Доступные устройства: " + d.Name + " - мощность " + d.ConsumptionPower + "\n");
            }
            Console.WriteLine("Соединить два устройства между собой и подключить : 1");
            Console.WriteLine("Подключить устройство к генератору : 2");
            Console.WriteLine("Отключить устройство от генератора : 3");
            int x1 = Convert.ToInt16(Console.ReadLine());
            switch (x1) {
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
                    switch (x4) {
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
                    var gen = generator.Devices;
                    Random rnd = new Random();
                    int value = rnd.Next(0, generator.Devices.Count - 1);
                    Console.WriteLine("Отключаем устройство " + gen[value].Name);
                    generator.DisconnectDevice(gen[value]);
                    generator.Output();
                    break;
            }
        }
    }
}
