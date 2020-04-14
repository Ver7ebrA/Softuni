
namespace RawData
{
    public class Engine
    {
        private int power;
        private int speed;

        public Engine(int power, int speed)
        {
            this.power = power;
            this.speed = speed;
        }

        public int Power
        {
            get { return this.power;}
        }

        public int Speed
        {
            get { return this.speed; }
        }
    }
}
