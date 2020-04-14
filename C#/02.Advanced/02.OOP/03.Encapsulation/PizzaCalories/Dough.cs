using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaCalories
{
    public class Dough
    {
        private const double BASE_CALORIES_PER_GRAM = 2.0;
        private const double WHITE_FLOUR_MODIFIER = 1.5;
        private const double WHOLEGRAIN_MODIFIER = 1.0;
        private const double CRISPY_MODIFIER = 0.9;
        private const double CHEWY_MODIFIER = 1.1;
        private const double HOMEMADE_MODIFIER = 1.0;

        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTehnique = bakingTechnique;
            this.Weight = weight;
        }

        private string FlourType
        {
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        private string BakingTehnique
        {
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        private int Weight
        {
            set
            {
                if (value < 1 || 200 < value)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        private double Calories()
        {
            double result = this.weight * BASE_CALORIES_PER_GRAM;

            if (this.flourType.ToLower() == "white")
            {
                result *= WHITE_FLOUR_MODIFIER;
            }
            else if (this.flourType.ToLower() == "wholegrain")
            {
                result *= WHOLEGRAIN_MODIFIER;
            }

            if (this.bakingTechnique.ToLower() == "crispy")
            {
                result *= CRISPY_MODIFIER;
            }
            else if (this.bakingTechnique.ToLower() == "chewy")
            {
                result *= CHEWY_MODIFIER;
            }
            else if (this.bakingTechnique.ToLower() == "homemade")
            {
                result *= HOMEMADE_MODIFIER;
            }

            return result;
        }

        public double GetCalories
        {
            get
            {
                return this.Calories();
            }
        }
    }
}
