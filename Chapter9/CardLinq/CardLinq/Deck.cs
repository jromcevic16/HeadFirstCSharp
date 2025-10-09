using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CardsLinq
{
    internal class Deck
    {
        public Card[] cards = new Card[52];
        Random r = new Random();
        public Deck() 
        {
            int index = 0;
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards[index++] = new Card((Values)value, (Suits)suit);
                }
            }
        }
        public void PrintCards()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine(cards[i].Name);
            }
        }
        public Deck Shuffle()
        {
            for(int i = 0; i < cards.Length; i++)
            {
                int c2 = r.Next(cards.Length);
                Card c = cards[i];
                cards[i] = cards[c2];
                cards[c2] = c;
            }
            return this;
        }
    }
}
