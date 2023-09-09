using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<ISoldier>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                try
                {
                    var token = command.Split();
                    var id = token[1];
                    var firstName = token[2];
                    var lastName = token[3];
                    decimal salary = 0;

                    if (token[0] == "Private" || token[0] == "LieutenantGeneral"
                        || token[0] == "Engineer" || token[0] == "Commando")
                    {
                        salary = decimal.Parse(token[4]);
                    }

                    if (token[0] == "Private")
                    {
                        list.Add(new Private(id, firstName, lastName, salary));
                    }
                    else if (token[0] == "Spy")
                    {
                        int codeNumber = int.Parse(token[4]);
                        list.Add(new Spy(firstName, lastName, id, codeNumber));
                    }
                    else if (token[0] == "LieutenantGeneral")
                    {
                        var currentLieutenant = new LieutenantGeneral(id, firstName, lastName, salary);
                        list.Add(currentLieutenant);

                        if (token.Length > 4)
                        {
                            for (int i = 5; i < token.Length; i++)
                            {
                                var privateID = token[i];

                                if (list.Any(x => x.Id == privateID))
                                {
                                    Private currentPrivate = (Private)list.First(x => x.Id == privateID);
                                    currentLieutenant.Privates.Add(currentPrivate);
                                }
                            }
                        }
                    }
                    else if (token[0] == "Engineer")
                    {
                        var corp = token[5];
                        var currentEngineer = new Engineer(id, firstName, lastName, salary, corp);
                        list.Add(currentEngineer);

                        if (token.Length > 5)
                        {
                            for (int i = 6; i < token.Length; i += 2)
                            {
                                string partName = token[i];
                                int hoursWorked = int.Parse(token[i + 1]);
                                currentEngineer.AddRepair(partName, hoursWorked);
                            }
                        }
                    }
                    else if (token[0] == "Commando")
                    {
                        var corp = token[5];
                        var currentCommando = new Commando(id, firstName, lastName, salary, corp);
                        list.Add(currentCommando);

                        if (token.Length > 5)
                        {
                            for (int i = 6; i < token.Length; i += 2)
                            {
                                string missionName = token[i];
                                string missionState = token[i + 1];
                                currentCommando.AddMission(missionName, missionState);
                            }
                        }
                    }
                }
                catch
                {

                }
            }

            foreach (var person in list)
            {
                Console.Write(person.ToString());
            }
        }
    }
}