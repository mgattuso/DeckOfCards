using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCards.Models
{
    public static class Deck
    {
        public static IEnumerable<Card> OrderedDeck()
        {
            foreach (var suit in Card.Suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    yield return new Card(i, suit);
                }
            }
        }

        public static IEnumerable<Card> RandomDeck()
        {
            Random rnd = new Random();
            return OrderedDeck().OrderBy(x => rnd.Next());
        }
    }
}
