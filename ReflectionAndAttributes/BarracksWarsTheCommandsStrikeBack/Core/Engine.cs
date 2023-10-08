using BarracksWarsANewFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarracksWarsANewFactory.Core
{
    public class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    var data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // TODO: refactor for Problem 4
        private string InterpredCommand(string[] data, string commandName)
        {
            commandName = commandName[0].ToString().ToUpper() + commandName.Substring(1) + "Command";
            Type typeOfCommand = Type.GetType("BarracksWarsANewFactory.Core.Commands." + commandName);
            IExecutable command = (IExecutable)Activator.CreateInstance(typeOfCommand, new object[] { data, repository, unitFactory });

            string result = command.Execute();
            return result;
        }
    }
}
