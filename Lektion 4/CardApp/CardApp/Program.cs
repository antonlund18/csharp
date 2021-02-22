using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp
{
    class Program
    {
        public static bool CardComparator(Card c1, Card c2)
        {
            if((int) c1.Number > (int) c2.Number)
            {
                return true;
            } else if ((int) c1.Number < (int) c2.Number)
            {
                return false;
            } else
            {
                return (int) c1.Color > (int) c2.Color ? true : false;
            }
        }

        static void Main(string[] args)
        {
            Deck d = new Deck();
            Console.WriteLine("***** Before sorting: *****");
            d.ShuffleDeck();
            d.PrintDeck();
            Console.WriteLine();
            Console.WriteLine("***** After sorting: *****");
            d.Sort(CardComparator);
            d.PrintDeck();
            Console.ReadKey();
        }
    }
}
