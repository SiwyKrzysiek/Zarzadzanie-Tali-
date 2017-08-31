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
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
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

        private void restoreDeck1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void shuffleDeck1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void restoreDeck2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffleDeck2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            deck2.Add(deck1.Deal(listBox1.SelectedIndex));
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            deck1.Add(deck2.Deal(listBox2.SelectedIndex));
            RedrawDeck(1);
            RedrawDeck(2);
        }

        void RedrawDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                listBox1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                    listBox1.Items.Add(cardName);
                label1.Text = string.Format("Zestaw 1. ({0} kart)", deck1.Count);
            }
            if (deckNumber == 2)
            {
                listBox2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                    listBox2.Items.Add(cardName);
                label2.Text = string.Format("Zestaw 2. ({0} kart)", deck2.Count);
            }
        }
    }
}
