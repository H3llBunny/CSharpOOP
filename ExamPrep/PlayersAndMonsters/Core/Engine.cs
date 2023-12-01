using PlayersAndMonsters.Core.Contracts;
using System;

namespace PlayersAndMonsters.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            IManagerController controller = new ManagerController();
            string input;

            while ((input = Console.ReadLine()) != "Exit")
            {
                var token = input.Split();
                var command = token[0];

                try
                {
                    switch (command)
                    {
                        case "AddPlayer":
                            var playertype = token[1];
                            var playerName = token[2];
                            Console.WriteLine(controller.AddPlayer(playertype, playerName));
                            break;

                        case "AddCard":
                            var cardType = token[1];
                            var cardName = token[2];
                            Console.WriteLine(controller.AddCard(cardType, cardName));
                            break;

                        case "AddPlayerCard":
                            var username = token[1];
                            var nameOfCard = token[2];
                            Console.WriteLine(controller.AddPlayerCard(username, nameOfCard));
                            break;

                        case "Fight":
                            var attacker = token[1];
                            var enemy = token[2];
                            Console.WriteLine(controller.Fight(attacker, enemy));
                            break;

                        case "Report":
                            Console.WriteLine(controller.Report());
                            break;

                        default:
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
