using System;

namespace PkmTCG
{
    /*
     * An attack is any move on a PkmCard which would end the turn 
     * (as opposed to pokemon powers, which do not end the turn).
     * An attack must have a non-negative value, but they may have a zero value.
     * Attacks with a zero value should not display that 0 on the card.
     * Attacks such as Scrunch on Chansey would be defined as an attack with no damage value 
     * and the Effect which would reduce damage.
     */ 
    class Attack
    {
        #region private fields

        private String desc;
        private int damage;
        private Effect effect;

        #endregion //private fields

        public Attack(int howMuchDamage, Effect theEffect)
        {
            this.damage = howMuchDamage;
            effect = theEffect;
        }
    }
}

