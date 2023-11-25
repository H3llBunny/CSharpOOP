namespace Composite
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            /*
            The Composite design pattern is a structural pattern that lets you compose 
            objects into tree-like structures to represent part-whole hierarchies. 
            It allows clients to treat individual objects and compositions of objects uniformly.
            */

            var phone = new SingleGift("Phone", 256);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            var rootBox = new CompositeGift("RootBox", 0);
            var truckToy = new SingleGift("TruckToy", 289);
            var plainToy = new SingleGift("PlainToy", 587);
            rootBox.Add(truckToy);
            rootBox.Add(plainToy);
            var childBox = new CompositeGift("ChildBox", 0);
            var soldierToy = new SingleGift("SoldierToy", 200);
            childBox.Add(soldierToy);
            rootBox.Add(childBox);

            Console.WriteLine($"Total price of this composite present is: {rootBox.CalculateTotalPrice()}");
        }
    }
}
