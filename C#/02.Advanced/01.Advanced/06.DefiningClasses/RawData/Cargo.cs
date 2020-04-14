
namespace RawData
{
    public class Cargo
    {
        private string type;
        private int weigth;

        public Cargo(string type, int weigth)
        {
            this.type = type;
            this.weigth = weigth;
        }

        public string Type
        {
            get { return this.type; }
        }

        public int Weigth
        {
            get { return this.weigth; }
        }
    }
}
