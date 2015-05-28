using System;

namespace PkmTCG
{
    /**
     * A card is anything that is held in the hand and can be played. 
     * This includes:
     * Basic Pokemon Cards, Evolution Pokemon Cards, Trainer Cards and Energy Cards.
     * All types of cards have a name, a rarity and what number in the set it is. 
     * ID is intended to be unique to each card and for internal use.
     */ 
    public abstract class Card
    {
        #region enums
        protected enum Rarity { Common, Uncommon, Rare, HoloRare };
        protected enum PokemonType { Colorless, Fighting, Fire, Grass, Lightning, Psychic, Water };
        //If we want to go that far, Darkness , Steel, and Fairy can be added later.
        #endregion //enums

        #region private fields
        private String cardName;
        private Rarity howRare;
        private int setNumber;
        private int id;
       
        #endregion private fields

        public Card(String name, Rarity thisRare, int setNum, int cardID)
        {
            cardName = name;
            howRare = thisRare;
            setNumber = setNum;
            id = cardID;
        }
    }
}
