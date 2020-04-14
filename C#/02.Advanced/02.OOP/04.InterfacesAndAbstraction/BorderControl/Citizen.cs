using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentifiable, IBirthdayable, IBuyer
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id, string birthay)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthay;
            this.Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string Birthday { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
