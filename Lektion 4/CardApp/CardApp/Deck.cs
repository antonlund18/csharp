using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp
{
    class Deck
    {
        public List<Card> deck;

        public delegate bool Comparator(Card c1, Card c2);

        public Deck()
        {
            deck = new List<Card>();
            for(int i = 1; i <= 13; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    deck.Add(new Card(i, j));
                }
            }
        }

        public void Sort(Comparator compare)
        {
            Card temp;
            for (int j = 0; j <= deck.Count() - 2; j++)
            {
                for (int i = 0; i <= deck.Count() - 2; i++)
                {
                    if (compare(deck[i], deck[i + 1]))
                    {
                        temp = deck[i + 1];
                        deck[i + 1] = deck[i];
                        deck[i] = temp;
                    }
                }
            }
        }

        public void PrintDeck()
        {
            int i = 1;
            foreach(Card c in deck)
            {
                Console.WriteLine($"{i++}: {c}");
            }
        }

        public void ShuffleDeck()
        {
            Random rand = new Random();
            for(int i = 0; i < 1000; i++)
            {
                int index1 = rand.Next(52);
                int index2 = rand.Next(52);
                Card temp = deck[index1];
                deck[index1] = deck[index2];
                deck[index2] = temp;
            }
        }
    }
}
