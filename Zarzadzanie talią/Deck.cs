using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarzadzanie_talią
{
    public class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    cards.Add( new Card( (Suits)i, (Values)j ) );
                }
            }
        }

        public Deck(IEnumerable<Card> initalCards)
        {
            cards = new List<Card>(initalCards);
        }

        public int Count => cards.Count;

        public void Add(Card card)
        {
            cards.Add(card);
        }

        public Card Deal(int index)
        {
            Card card = cards[index];
            cards.RemoveAt(index);
            return card;
        }

        public void Shuffle()
        {
            for (int i = cards.Count-1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);

                Card buffor = cards[i];
                cards[i] = cards[j];
                cards[j] = buffor;
            }
        }

        public IEnumerable<string> GetCardNames()
        {
            List<string> nazwy = new List<string>();

            foreach (Card card in cards)
            {
                nazwy.Add(card.Name);
            }
            return nazwy;
        }

        public void Sort()
        {
            cards.Sort(new CardComperer_bySuit());
        }

        
    }
}
