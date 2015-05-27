using System;

namespace PkmTCG
{
    /**
     * Prizes are a special type of card. When you have no prizes left, you win the game.
     * This class might be more useful as a Prizes class which holds a list of cards left in the prize pool.
     */ 
    public class Prize
    {
        private Card butThePrize;

        public Prize(Card card)
        {
            butThePrize = card;
        }

        /**
         * Add the prize to your hand.
         * 
         */
        private Card AddToHand()
        {
            return butThePrize;
        }


    }
}