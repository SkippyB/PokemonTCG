using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkmTCG
{
    /**
     * A hand contains all the cards available to play. 
     * There is no upper limit on the number of cards a player can have, but they must have a non-negative amount.
     * 
     */ 
    class Hand
    {
        #region private fields
        List<Card> cardsInHand;
        #endregion //private fields


        public Hand(List<Card> drawnHand)
        {
            cardsInHand = drawnHand;
        }

        #region private methods

        private void ShuffleCardIntoDeck(int cardsToShuffle)
        {
            
        }

        private bool Contains(Card card)
        {
            return false;
        }
        #endregion //private methods

    }
}

