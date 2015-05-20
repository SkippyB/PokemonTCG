using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkmTCG
{
    class Deck
    {
        private void shuffle()
        {

        }

        private Card draw()
        {
            return null;
        }

        private bool containsCard(Card toSearch)
        {
            return false;
        }

        private Card seachDeck(Card toSearch)
        {
            return null;
        }




        private class DeckNode
        {
            Card card;
            DeckNode next;

            private DeckNode(Card theCard, DeckNode nextCard)
            {
                card = theCard;
                next = nextCard;
            }

            private DeckNode(Card theCard)
            {
                card = theCard;
                next = null;
            }



        }
    }
}
