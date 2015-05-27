using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkmTCG
{
    class Deck
    {
        #region private fields

        List<Card> deck;
        static readonly int SHUFFLE_COUNT = 10000;

        #endregion //private fields



        #region public methods

        public Card Draw()
        {
            Card drawnCard = deck.First();
            deck.RemoveAt(0);
            return drawnCard;
        }
        
        #endregion //public methods

        #endregion //public methods



        #region private methods

        private void Shuffle()
        {
            Random shuffler = new Random();

            for (int i = 0; i < SHUFFLE_COUNT; i++)
            {
                int from = shuffler.Next(deck.Count);
                int to = shuffler.Next(deck.Count);

                Card temp = deck.ElementAt(to);
                deck.RemoveAt(to);
                deck.Insert(to, deck.ElementAt(from));
                deck.RemoveAt(from);
                deck.Insert(from, temp);
            }
        }

        private bool ContainsCard(Card toSearch)
        {
            return SearchDeck(toSearch) != null;
        }

        private Card SearchDeck(Card toSearch)
        {
            return deck.First(x => x.Equals(toSearch));
        }

        #endregion //private methods
    }
}
