using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> playersList;

        public Team(string name)
        {
            this.Name = name;
            this.PlayersList = new List<Player>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"A name should not be empty.");
                }
                this.name = value;
            }
        }

        private List<Player> PlayersList
        {
            get => this.playersList;
            set => this.playersList = value;
        }

        public int Rating { get => CalculateTeamRating(); }

        private int CalculateTeamRating()
        {
            if (this.playersList.Any())
            {
                return (int)Math.Round(this.playersList.Average(p => p.Stats));
            }
            else
            {
                return 0;
            }
        }

        public void AddPlayer(Player player)
        {
            this.playersList.Add(player);
        }

        public void RemovePlayer(string player)
        {
            if (!this.playersList.Any(p => p.Name == player))
            {
                throw new ArgumentException($"Player {player} is not in {this.Name} team. ");
            }

            Player pl = this.playersList.FirstOrDefault(p => p.Name == player);
            this.playersList.Remove(pl);
        }

        public override string ToString()
        {
            return $"{this.name} - {this.Rating}";
        }
    }
}
