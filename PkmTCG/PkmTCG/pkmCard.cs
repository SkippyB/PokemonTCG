using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkmTCG
{
    /*
     * Pokemon cards are the heart of the game.
     * All pokemon must have at LEAST 1 attack, though that attack does not necessarily need to do damage.
     */ 
    class PkmCard : Card
    {
        /*
         * Robert:
         * RE: Costs
         * Retreat costs don't bother me, since every retreat cost I've ever 
         * seen has just been some amount of colorless energy, but how do we handle 
         * attack costs?
         */ 

        #region private fields

        private int level;
        private int health;
        private PokemonType type;

        private Attack first;
        private Attack second;
        private Effect pkmPower;

        private String desc;
        private int pkmNum;
        private int retreatCost;
        private PokemonType weakness;
        private PokemonType resistance;

        private List<EnergyCard> attachedEnergy;

        #endregion //private fields

        /*
         * Robert:
         * This constructor could be pretty beefy if we try to do most of these fields at once. 
         * Suggestions would be appreciated.
         */
        private PkmCard(String name, Rarity thisRare, int setNum, int id, Attack firstAttack) : base(name, thisRare, setNum, id)
        {
           
        }
    }
}

