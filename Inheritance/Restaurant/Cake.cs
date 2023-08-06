namespace Restaurant.FoodProducts
{
    public class Cake : Dessert
    {
        private const double cakeGrams = 350;
        private const double cakeCalories = 1000;
        private const decimal cakePrice = 5;

        public Cake(string name)
            : base(name, cakePrice, cakeGrams, cakeCalories)
        {
        }

        public override double Grams { get => cakeGrams; }

        public override double Calories { get => cakeCalories; }

        public override decimal Price { get => cakePrice; }
    }
}
