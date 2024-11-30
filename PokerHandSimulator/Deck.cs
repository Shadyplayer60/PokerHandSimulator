using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PokerHandSimulator
{
    public class Deck
    {
        private List<Card> cards;
        private ImageList imageList;

        public Deck(ImageList imageList)
        {
            this.imageList = imageList ?? throw new ArgumentNullException(nameof(imageList));
            cards = new List<Card>();
            Shuffle();
        }

        public void Shuffle(Card[]? hand = null)
        {
            cards.Clear();

            // Add cards to the deck, excluding kept cards if `hand` is provided
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                bool isKept = false;

                if (hand != null)
                {
                    foreach (var card in hand)
                    {
                        if (card != null && card.Id == i)
                        {
                            isKept = true;
                            break;
                        }
                    }
                }

                if (!isKept)
                {
                    // Use the ImageList key as the card name
                    string name = imageList.Images.Keys[i];
                    cards.Add(new Card(i, imageList.Images[i], name));
                }
            }

            // Shuffle the deck
            Random rng = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (cards[i], cards[j]) = (cards[j], cards[i]); // Swap
            }
        }

        public Card DealCard()
        {
            if (cards.Count > 0)
            {
                Card dealtCard = cards[0];
                cards.RemoveAt(0);

                // Show a message if the deck is empty
                if (cards.Count == 0)
                {
                    MessageBox.Show("Out of Cards. Please shuffle the deck.", "Deck Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return dealtCard;
            }

            return Card.NoCard;
        }

        public int Count => cards.Count;

        public Card GetCard(int index)
        {
            return (index >= 0 && index < cards.Count) ? cards[index] : Card.NoCard;
        }

        public void SwapCards(int index1, int index2)
        {
            if (index1 >= 0 && index1 < cards.Count && index2 >= 0 && index2 < cards.Count)
            {
                (cards[index1], cards[index2]) = (cards[index2], cards[index1]); // Swap cards
            }
        }

        public bool SaveHand(string filename, Card[] hand)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (var card in hand)
                    {
                        writer.WriteLine(card?.Id ?? -1);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving hand: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool LoadHand(string filename, Card[] hand)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    for (int i = 0; i < hand.Length; i++)
                    {
                        if (reader.Peek() >= 0)
                        {
                            int id = int.Parse(reader.ReadLine());
                            string name = id >= 0 && id < imageList.Images.Count ? imageList.Images.Keys[id] : "No Card";
                            hand[i] = id >= 0 ? new Card(id, imageList.Images[id], name) : Card.NoCard;
                        }
                        else
                        {
                            hand[i] = Card.NoCard;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading hand: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
