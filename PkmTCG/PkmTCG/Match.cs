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
    class Match
    {
        //begin match
        //two decks
        //draw 7 cards
        //place # of prizes (2, 4, 6)
        //coin flip for first

        /*
            Drawing a card. Every turn, without exception, starts with a draw.
            Hosts a loss condition (fatigued).
            List of events:
                Player draws a card if possible.
        */
        public void DrawPhase()
        {
        }

        /*
            Bulk of a turn.
            List of events:
                Play any number of basic pokemon.
                Play any number of trainers.
                Utilize existing pokemon powers if possible.
                Retreat pokemon if possible.
                Evolve pokemon capable of it up to one step each.
                Play one energy (extra energy per turn can be handled via effects)
        */
        public void MainPhase()
        {
        }

        /*
            Attack the enemy's active pokemon.
            List of events:
                Declare attack - may not be possible. (ex. paralysis)
                Handle effects of enemy pokemon (ex. agility)
                Do damage to enemy active pokemon.
                Apply effects to enemy pokemon.
        */
        public void AttackPhase()
        {
        }

        /*
            End of the turn. Triggered via passing or attacking.
            List of events:
                If any pokemon died, opposite trainer draws a prize.
                If any pokemon died, owner replaces with a benched pokemon if possible.
                Resolve status effects.
        */
        public void EndPhase()
        {
        }
    }
}