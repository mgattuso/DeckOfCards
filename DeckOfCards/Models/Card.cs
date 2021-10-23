using System;
using System.Linq;

namespace DeckOfCards.Models
{
    public class Card
    {
        public Card(int value, string suit)
        {
            if (!Suits.Contains(suit)) throw new ArgumentException("Suit name not recognized", nameof(suit));
            this.Suit = suit;
            this.Value = value;
            this.Name = value.ToString();
            switch (value)
            {
                case 1: this.Name = "Ace"; break;
                case 11: this.Name = "Jack"; break;
                case 12: this.Name = "Queen"; break;
                case 13: this.Name = "King"; break;
            }

            this.Color = suit == "Clubs" || suit == "Spades" ? "Black" : "Red";
        }

        public int Value { get; set; }
        public string Name { get; set; }
        public string Suit { get; set; }
        public string Color { get; set; }

        public string Display => Name + " of " + Suit;

        public static string[] Suits => new string[] { "Clubs", "Spades", "Hearts", "Diamonds" };

    }
}