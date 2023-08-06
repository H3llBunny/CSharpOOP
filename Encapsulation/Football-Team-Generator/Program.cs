namespace FootballTeamGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teamsList = new List<Team>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];
                string teamName = tokens[1];

                try
                {
                    switch (command)
                    {
                        case "Team":
                            teamsList.Add(new Team(teamName));
                            break;

                        case "Add":
                            if (!teamsList.Any(t => t.Name == teamName))
                            {
                                throw new ArgumentException($"Team {teamName} does not exist.");
                            }
                            else
                            {
                                string playerName = tokens[2];
                                int endurance = int.Parse(tokens[3]);
                                int spring = int.Parse(tokens[4]);
                                int dribble = int.Parse(tokens[5]);
                                int passing = int.Parse(tokens[6]);
                                int shooting = int.Parse(tokens[7]);
                                var currentPlayer = new Player(playerName, endurance, spring, dribble, passing, shooting);
                                var currentTeam = teamsList.First(t => t.Name == teamName);
                                currentTeam.AddPlayer(currentPlayer);
                            }
                            break;

                        case "Remove":
                            var teamToRemove = teamsList.First(t => t.Name == teamName);
                            string playerToBeRemove = tokens[2];
                            teamToRemove.RemovePlayer(playerToBeRemove);
                            break;

                        case "Rating":
                            if (!teamsList.Any(t => t.Name == teamName))
                            {
                                throw new ArgumentException($"Team {teamName} does not exist.");
                            }
                            else
                            {
                                Console.WriteLine(teamsList.First(t => t.Name == teamName).ToString());
                            }
                            break;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}