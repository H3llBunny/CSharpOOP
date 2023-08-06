using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Dough
    {
        private const double White = 1.5;
        private const double Wholegrain = 1.0;
        private const double Crispy = 0.9;
        private const double Chewy = 1.1;
        private const double Homemade = 1.0;
        private string doughType;
        private string bakingTechnique;
        private double grams;
        internal double doughModifierGrams;
        internal double bakingModifierGrams;

        public Dough(string doughType, string bakingTechnique, double grams)
        {
            this.DoughType = doughType;

            switch (doughType.ToLower())
            {
                case "white":
                    this.doughModifierGrams = White;
                    break;
                case "wholegrain":
                    this.doughModifierGrams = Wholegrain;
                    break;
            }

            this.BakingTechnique = bakingTechnique;

            switch (bakingTechnique.ToLower())
            {
                case "crispy":
                    this.bakingModifierGrams = Crispy;
                    break;
                case "chewy":
                    this.bakingModifierGrams = Chewy;
                    break;
                case "homemade":
                    this.bakingModifierGrams = Homemade;
                    break;
            }
            this.Grams = grams;
        }

        public string DoughType
        {
            get => this.doughType;
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.doughType = value;
            }
        }
        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        public double Grams
        {
            get => this.grams;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.grams = value;
            }
        }
    }
}
