using System;
using System.Collections.Generic;

namespace Generator {
    class Generator {
        public int power { get; set; }
        public List<Device> Devices = new List<Device>();
        public List<Device> Alldevices = new List<Device>();
        //Все устройства
        public void AddAlldevices(params Device[] device) {
            foreach (Device d in device) {
                Alldevices.Add(d);
            }
        }
        //Совмещение двух устройств
        public void PairOfDevices(Device device1, Device device2) {
            if (device1.IsPairing | device2.IsPairing) {
                Console.WriteLine("устройства совмещены");
            } else if (device1.Power + device2.Power > power) {
                Console.WriteLine("Невозможно совместить эти два устройства, суммарная мощность больше мощности генератора");
            } else {
                device1.IsPairing = true;
                device2.IsPairing = true;
                Device devicepair = new Device(device1.Name + " " + device2.Name, device1.Power + device2.Power);
                Devices.Add(devicepair);
            }
        }
        //Подключение к генератору
        public void AddDevice(Device device) {
            int sum = 0;
            foreach (Device d in Devices) {
                sum += d.Power;
            }
            if (sum + device.Power < power) {
                Devices.Add(device);
                Console.WriteLine("Подключили устройство:" + device.Power);
            } else {
                Console.WriteLine("Привышенна мощность генератора,подключение невозможно");
            }
        }
        //Отключение от генератора
        public void DisconnectDevice(Device device) {
            if (Devices.Contains(device)) {
                Devices.Remove(device);
            } else {
                Console.WriteLine("Это устройство не подключено");
            }
        }
        public void Output() {
            int sum = 0;
            foreach (Device d in Devices) {
                sum += d.Power;
                Console.WriteLine("Подключённые устройства:" + d.Name + "\t" + "Суммарная мощность:" + sum);
            }
        }
        public Generator(int power) {
            this.power = power;
        }
        public Generator() {
        }
    }

}
