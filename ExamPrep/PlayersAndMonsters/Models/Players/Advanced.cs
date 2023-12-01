using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Players
{
    public class Advanced : Player
    {
        private const int InitialHealth = 250;

        public Advanced(ICardRepository cardRepo, string username) : base(cardRepo, username, InitialHealth)
        {
        }
    }
}
