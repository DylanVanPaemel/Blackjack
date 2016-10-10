using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackJackGame.Models;

namespace BlackjackGame.Models
{
    public class Card
    {
        public FaceValue FaceValue { get; set; }
        public Suit Suit { get; set; }

        public Card(Suit suit, FaceValue faceValue)
        {
            this.FaceValue = faceValue;
            this.Suit = suit;
        }
       
    }
}
