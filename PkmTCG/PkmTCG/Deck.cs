using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkmTCG
{
    /**
     * The Deck is what is drawn from during the match and put together from the collection during Deck construction.
     * Maybe take a list to create the object at the beginning of a match?
     */ 
    class Deck
    {
        #region private fields

        List<Card> deck;
        static readonly int SHUFFLE_COUNT = 10000;
        static readonly int STARTING_HAND_SIZE = 7;
        
        #endregion //private fields



        #region public methods

        public List<Card> DrawStartingHand()
        {
            List<Card> temp = new List<Card>();
            for (int i = 0; i < STARTING_HAND_SIZE; i++)
            {
                temp.Add(Draw());
            }
            return temp;
        }

        public List<Card> DrawPrizes(int numPrizes)
        {
            List<Card> temp = new List<Card>();
            for (int i = 0; i < numPrizes; i++)
            {
                temp.Add(Draw());
            }
            return temp;
        }
        
        public Card Draw()
        {
            Card drawnCard = deck.First();
            deck.RemoveAt(0);
            return drawnCard;
        }

        //search?
        
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
