namespace AbstractFactoryExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Abstract Factory pattern provides an interface for creating families of related or 
            dependent objects without specifying their concrete classes. 
            */

            IFurnitureFactory modernFactory = new ModernFurnitureFactory();
            IFurnitureFactory victorianFactory = new VictorianFurnitureFactory();

            IChair modernChair = modernFactory.CreateChair();
            ITable modernTable = modernFactory.CreateTable();

            IChair victorianChair = victorianFactory.CreateChair();
            ITable victorianTable = victorianFactory.CreateTable();

            modernChair.Display();
            modernTable.Display();

            victorianChair.Display();
            victorianTable.Display();
        }
    }
}