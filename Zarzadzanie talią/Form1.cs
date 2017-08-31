using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarzadzanie_talią
{
    public partial class Form1 : Form
    {
        Deck deck1, deck2;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            
        }

        void ResetDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                int numberOfCards = random.Next(1, 11);
                deck1 = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                {
                    deck1.Add(new Card());
                }

                deck1.Sort();
            }
            if (deckNumber == 2)
                deck2 = new Deck();
        }

        void RedrawDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                listBox1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                    listBox1.Items.Add(cardName);
            }
            if (deckNumber == 2)
            {
                listBox2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                    listBox2.Items.Add(cardName);
            }
        }
    }
}
