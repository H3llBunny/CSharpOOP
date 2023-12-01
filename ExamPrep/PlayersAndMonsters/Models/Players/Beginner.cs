using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Players
{
    public class Beginner : Player
    {
        private const int InitialHealth = 50;
        public Beginner(ICardRepository cardRepo, string username) : base(cardRepo, username, InitialHealth)
        {
        }
    }
}
