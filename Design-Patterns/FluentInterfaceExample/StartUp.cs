namespace FluentInterfaceExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            Fluent Interface allows method chaining, creating a more readable and 
            expressive code. It is often used to build a domain-specific language 
            (DSL) within the programming language.
            */

            Car car = new Car()
                .SetMake("Toyota")
                .SetModel("Camry")
                .SetYear(2022);

            car.DisplayInfo();
        }
    }
}