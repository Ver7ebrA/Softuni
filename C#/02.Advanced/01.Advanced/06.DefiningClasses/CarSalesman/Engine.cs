

namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
        }

        public Engine(string model, int power, string efficiency)
            :this(model, power)
        {
            this.efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement)
            :this(model, power)
        {
            this.displacement = displacement;
        }

        public Engine(string model, int power, int displacement, string efficiency)
            :this(model, power, displacement)
        {
            this.efficiency = efficiency;
        }

        public string Model
        {
            get { return this.model; }
        }

        public int Power
        {
            get { return this.power; }
        }

        public int Displacement
        {
            get { return this.displacement; }
        }

        public string Efficiency
        {
            get { return this.efficiency; }
        }
    }
}
