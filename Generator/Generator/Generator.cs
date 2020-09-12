using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Generator
{
    class Generator
    {
        public int power { get; set; }
        public List<Device> devices = new List<Device>();
        public List<Device> alldevices = new List<Device>();

        //Все устройства


        public void Alldevices(params Device[] device)
        {
            foreach (Device d in device)
            {
                alldevices.Add(d);
            }

        }
        //Совмещение двух устройств
        public void PairOfDevices(Device device1, Device device2)
        {
            if (device1.ispairing | device2.ispairing)
            {
                Console.WriteLine("устройства совмещены");
            }
            else if (device1.power + device2.power > power)
            {
                Console.WriteLine("Невозможно совместить эти два устройства, суммарная мощность больше мощности генератора");
            }
            else
            {
                device1.ispairing = true;
                device2.ispairing = true;
                Device devicepair = new Device(device1.name +" "+ device2.name, device1.power + device2.power);
                devices.Add(devicepair);
            }

        }
        //Подключение к генератору
        public void AddDevice(Device device)
        {
            int sum = 0;
            foreach(Device d in devices)
            {
                sum += d.power;
            }
            if (sum+device.power < power)
            {
                devices.Add(device);
                Console.WriteLine("Подключили устройство:" + device.power);
            }
            else
            {
                Console.WriteLine("Привышенна мощность генератора,подключение невозможно");
            }          
        }



        //Отключение от генератора
        public void DisconnectDevice(Device device)
        {
            if (devices.Contains(device))
            {
                devices.Remove(device);
            }
            else
            {
                Console.WriteLine("Это устройство не подключено");
            }
        }
        public void Output()
        {
            int sum = 0;
            foreach (Device d in devices)
            {
                sum += d.power;
                Console.WriteLine("Подключённые устройства:" + d.name + "\t" + "Суммарная мощность:" + sum);
            }
                
                
        }

        public Generator(int power)
        {
            this.power = power;
        }
        public Generator()
        {

        }
    }
    
}
