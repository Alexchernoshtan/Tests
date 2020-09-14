namespace Generator {
    public class Device {
        public string Name { get; set; }
        public int Power { get; set; }
        public bool IsPairing { get; set; }

        public Device(string name, int power) {
            this.Name = name;
            this.Power = power;
        }
    }
}
