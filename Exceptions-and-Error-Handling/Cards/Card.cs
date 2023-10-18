using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Card
    {
        private List<string> faces = new List<string>() { "2", "3", "4", "5", "6"
            , "7", "8", "9", "10", "J", "Q", "K", "A" };
        private Dictionary<string, string> suits = new Dictionary<string, string>() { { "S", "\u2660" }, { "H", "\u2665" },
            { "D", "\u2666"}, { "C", "\u2663" } };
        private string face;
        private string suit;

        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        private string Face
        {
            get => this.face;

            set
            {
                if (this.faces.Contains(value))
                {
                    this.face = value;
                }
                else
                {
                    throw new FormatException("Invalid card!");
                }
            }
        }

        private string Suit
        {
            get => this.suit;

            set
            {
                if (suits.ContainsKey(value))
                {
                    this.suit = suits[value];
                }
                else
                {
                    throw new FormatException("Invalid card!");
                }
            }
        }

        public override string ToString()
        {
            return $"[{this.Face}{this.suit}]";
        }
    }
}
