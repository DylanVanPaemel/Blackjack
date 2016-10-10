using BlackJackGame.Models;


namespace BlackjackGame.Models
{
    public class BlackJackCard : Card
    {
        public bool FaceUp { get; set; }
        public int Value { get; }

        public BlackJackCard(Suit suit, FaceValue faceValue) : base(suit, faceValue)
        {
            FaceUp = false;
            Value = 0;

        }

        public void TurnCard()
        {
            FaceUp = true;
            
        }
    }
}
