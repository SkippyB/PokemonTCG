using System;

namespace PkmTCG
{
    /*
        Starts a match between two Decks.
        Handles coinflips, phase changes, etc.
        List of events (upon construction):
            Begin a match between two decks.
            Draw seven cards.
            Place n prizes (2, 4, 6 typical)
            Coin flip for first player.
    */

    /*
     * Robert:
     * I think this might work better if a match was an indefinite series of Turns 
     * and a Turn class handled things like drawing, attacking etc.
     * Maybe have the Match listen to the Turns for things like Pokemon fainting?
     */ 
    class Match
    {
        //begin match
        //two decks
        //draw 7 cards
        //place # of prizes (2, 4, 6)
        //coin flip for first
        

        /*
            Drawing a card. Every turn, without exception, starts with a draw.
            Hosts a loss condition (out of cards).
            List of events:
                Player draws a card if possible.
        */
        public void DrawPhase()
        {
            //if deck.size == turn 0 player loses
            
        }

        /*
            Bulk of a turn.
            List of events (no particular order):
                Play cards, including:
                    any number of basic pokemon.
                    any number of trainers.
                    Evolve pokemon that have been on the field for at least 1 turn.
         
                Utilize existing pokemon powers if possible.
                Retreat pokemon if wanted and possible.
                Play up to one energy 
                (extra energy per turn can be handled via effects)
        */
        public void MainPhase()
        {
        }

        /*
            Robert: I'd argue that if a pokemon is incapable of attacking for some reason, 
            you shouldn't be able to attack at all.   
          
            Attack the enemy's active pokemon with your active pokemon.
            List of events:
                Declare attack - may not be possible. (ex. paralysis)
                Handle effects of enemy pokemon (ex. agility, scrunch)
                Do damage to enemy active pokemon.
                Apply effect of the attack, if any.
        */
        public void AttackPhase()
        {
        }

        /*
            Robert: prizes can't be handled during the end phase.
            EX: I use the Pokemon Power on my Gengar to move a damage counter to something 
            with 10 health left and it dies. I should get my prize as soon as that happens.
            Moving pokemon up to the bench can't just be handled here for the same reason.
            
            End of the turn. Triggered via passing or attacking.
            List of events:
                If any pokemon died, opposite trainer draws a prize.
                If any pokemon died, owner replaces with a benched pokemon if possible.
                Resolve status effects.
            Robert: I think just sleep and paralyze are checked here. 
        */
        public void EndPhase()
        {
        }
    }
}
