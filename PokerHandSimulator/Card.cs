using System.Drawing;

namespace PokerHandSimulator
{
    public class Card
    {
        public int Id { get; } // Read-only ID of the card
        public Image? CardImage { get; } // Read-only image of the card
        public string Name { get; } // Read-only name of the card

        // Static readonly pseudo constant for representing "No Card"
        public static readonly Card NoCard = new Card(-1, null, "No Card");

        // Constructor to initialize Card with ID, Image, and Name
        public Card(int id, Image? image, string name)
        {
            if (id < -1 || id >= 52) // Validate card ID
                throw new ArgumentOutOfRangeException(nameof(id), "Card ID must be between -1 and 51.");

            Id = id;
            CardImage = image;
            Name = name ?? "Unnamed Card";
        }

        // Override ToString() to return the Name
        public override string ToString()
        {
            return Name;
        }
    }
}
