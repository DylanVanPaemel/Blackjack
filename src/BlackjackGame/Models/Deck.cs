using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackJackGame.Models;

namespace BlackjackGame.Models
{
    public class Deck
    {
        private Random _random;
        private IList<BlackJackCard> _cards;

        public Deck()
        {
            foreach(FaceValue f in Enum.GetValues(typeof(FaceValue)))
            foreach (Suit s in Enum.GetValues(typeof(Suit))) 
            {
                
                    _cards.Add(new BlackJackCard(s,f));
             
                
            }
        }

        public BlackJackCard Draw()
        {
            if (_cards.Count != 0)
            {
                return _cards[_cards.Count - 1];
            }
            else
            {
                throw new InvalidOperationException("Er zijn geen kaarten meer op de stapel.");
            }
        }

        public void Shuffle()
        {
            _random = new Random();
            int n = _cards.Count;
            while (n > 1)
            {
                n--;
                int k = _random.Next(n + 1);
                BlackJackCard b = _cards[k];
                _cards[k] = _cards[n];
                _cards[n] = b;

            }

            
        }

    }
}
