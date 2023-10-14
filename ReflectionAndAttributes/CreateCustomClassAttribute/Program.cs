using Inferno_Infinity.Contracts;
using Inferno_Infinity.Core;
using Inferno_Infinity.Core.Factories;
using Inferno_Infinity.Data;

namespace Inferno_Infinity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repository = new WeaponRepository();
            var interpreter = new CommandInterpreter();
            var weaponFactory = new WeaponFactory();
            var gemFactory = new GemFactory();

            IRunnable engine = new Engine(gemFactory, weaponFactory, interpreter, repository);

            engine.Run();
        }
    }
}