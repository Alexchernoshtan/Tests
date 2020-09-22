namespace Generator
{
    class Generator
    {
        public int Power { get; }
        public Device Child { get; set; }
        public Generator(int power)
        {
            this.Power = power;
        }
    }
}
