using System;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }       

        public Car(string model, Engine engine, string color)
            :this(model, engine)
        {
            this.color = color;
        }

        public Car(string model, Engine engine, int weight)
            :this(model, engine)
        {
            this.weight = weight;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine, weight)
        {
            this.color = color;
        }

        public string Model
        {
            get { return this.model; }
        }

        public Engine Engine
        {
            get { return this.engine; }
        }

        public int Weight
        {
            get { return this.weight; }
        }

        public string Color
        {
            get { return this.color; }
        }

        public override string ToString()
        {
            string result = $"{this.model}:";
            result = string.Concat(result, Environment.NewLine, $"  {this.Engine.Model}:");
            result = string.Concat(result, Environment.NewLine, $"    Power: {this.Engine.Power}");
            result = string.Concat(result, Environment.NewLine, this.Engine.Displacement == 0 ? 
                "    Displacement: n/a" : $"    Displacement: {this.Engine.Displacement}");
            result = string.Concat(result, Environment.NewLine, this.Engine.Efficiency == null ?
                "    Efficiency: n/a" : $"    Efficiency: {this.Engine.Efficiency}");
            result = string.Concat(result, Environment.NewLine, this.Weight == 0 ? "  Weight: n/a" : $"  Weight: {this.weight}");
            result = string.Concat(result, Environment.NewLine, this.Color == null ? "  Color: n/a" : $"  Color: {this.Color}");
            return result;
        }
    }
}
