using System;
using System.Windows.Forms;

namespace PokerHandSimulator
{
    public partial class MainForm : Form
    {
        private Deck deck;
        private Card[] hand;
        private DeckForm deckForm; // Reference to the DeckForm

        public MainForm()
        {
            InitializeComponent();
            hand = new Card[5];
            deck = new Deck(imageCardsList); // Initialize the Deck with ImageList
            deck.Shuffle(); // Shuffle the deck initially
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DealHand(); // Deal an initial hand
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            DealHand(); // Deal a new hand
            deckForm?.RefreshDeck(); // Notify DeckForm to update if it is open
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            deck.Shuffle(hand); // Shuffle the deck, excluding kept cards
            MessageBox.Show("The deck has been shuffled.", "Shuffle Deck", MessageBoxButtons.OK, MessageBoxIcon.Information);
            deckForm?.RefreshDeck(); // Notify DeckForm to update if it is open
        }

        private void btnSaveHand_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = "C:\\",
                DefaultExt = ".txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!deck.SaveHand(saveFileDialog.FileName, hand))
                {
                    MessageBox.Show("Failed to save hand.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadHand_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "C:\\",
                DefaultExt = ".txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!deck.LoadHand(openFileDialog.FileName, hand))
                {
                    MessageBox.Show("Failed to load hand.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UpdateAllPictureBoxes(); // Update the UI to reflect the loaded hand
                    deckForm?.RefreshDeck(); // Notify DeckForm to update if it is open
                }
            }
        }

        private void btnShowDeck_Click(object sender, EventArgs e)
        {
            // Check if the DeckForm is already open
            if (deckForm == null || deckForm.IsDisposed)
            {
                deckForm = new DeckForm(deck);
                deckForm.Show(); // Show the DeckForm as a non-modal form
                deckForm.FormClosed += DeckForm_FormClosed; // Handle DeckForm closure
            }
            else
            {
                deckForm.BringToFront(); // Bring the existing DeckForm to the front
            }
        }

        private void DeckForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            deckForm = null; // Clear the reference when DeckForm is closed
        }

        private void DealHand()
        {
            for (int i = 0; i < 5; i++)
            {
                if (!GetKeepCheckbox(i).Checked)
                {
                    hand[i] = deck.DealCard(); // Use Deck's DealCard method
                }
            }
            UpdateAllPictureBoxes(); // Update all PictureBoxes
        }

        private void UpdateAllPictureBoxes()
        {
            // Simplified PictureBox image updating
            picCard1.Image = hand[0]?.CardImage;
            picCard2.Image = hand[1]?.CardImage;
            picCard3.Image = hand[2]?.CardImage;
            picCard4.Image = hand[3]?.CardImage;
            picCard5.Image = hand[4]?.CardImage;
        }

        private CheckBox GetKeepCheckbox(int index)
        {
            return index switch
            {
                0 => chkKeep1,
                1 => chkKeep2,
                2 => chkKeep3,
                3 => chkKeep4,
                4 => chkKeep5,
                _ => null,
            };
        }

        private void picCard1_Click(object sender, EventArgs e)
        {
            chkKeep1.Checked = !chkKeep1.Checked;
        }

        private void picCard2_Click(object sender, EventArgs e)
        {
            chkKeep2.Checked = !chkKeep2.Checked;
        }

        private void picCard3_Click(object sender, EventArgs e)
        {
            chkKeep3.Checked = !chkKeep3.Checked;
        }

        private void picCard4_Click(object sender, EventArgs e)
        {
            chkKeep4.Checked = !chkKeep4.Checked;
        }

        private void picCard5_Click(object sender, EventArgs e)
        {
            chkKeep5.Checked = !chkKeep5.Checked;
        }
    }
}
