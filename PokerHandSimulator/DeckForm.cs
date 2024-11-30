using System;
using System.Windows.Forms;

namespace PokerHandSimulator
{
    public partial class DeckForm : Form
    {
        private readonly Deck deck;

        public DeckForm(Deck deck)
        {
            InitializeComponent();
            this.deck = deck ?? throw new ArgumentNullException(nameof(deck));
        }

        private void DeckForm_Load(object sender, EventArgs e)
        {
            UpdateDeck(); // Populate the ListBox with cards
        }

        public void RefreshDeck()
        {
            UpdateDeck(); // Update the ListBox with the latest deck data
        }

        private void UpdateDeck()
        {
            lstCards.Items.Clear();

            // Check if the deck is empty
            if (deck.Count == 0)
            {
                lstCards.Items.Add("No Cards"); // Add a placeholder entry when the deck is empty
                picCard6.Image = null; // Clear the PictureBox
            }
            else
            {
                // Populate the ListBox with cards from the deck
                for (int i = 0; i < deck.Count; i++)
                {
                    lstCards.Items.Add(deck.GetCard(i));
                }
            }
        }

        private void lstCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCards.SelectedItem is Card card)
            {
                // Set the PictureBox image to the selected card's image
                picCard6.Image = card.CardImage;
            }
            else
            {
                // Clear the PictureBox when "No Cards" is selected
                picCard6.Image = null;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lstCards.SelectedIndex >= 0)
            {
                int currentIndex = lstCards.SelectedIndex;
                int newIndex = currentIndex - 1;

                // Ensure the newIndex is valid
                if (newIndex >= 0)
                {
                    deck.SwapCards(currentIndex, newIndex);
                    UpdateDeck();
                    lstCards.SetSelected(newIndex, true);
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lstCards.SelectedIndex >= 0)
            {
                int currentIndex = lstCards.SelectedIndex;
                int newIndex = currentIndex + 1;

                // Ensure the newIndex is valid
                if (newIndex < deck.Count)
                {
                    deck.SwapCards(currentIndex, newIndex);
                    UpdateDeck();
                    lstCards.SetSelected(newIndex, true);
                }
            }
        }
    }
}
