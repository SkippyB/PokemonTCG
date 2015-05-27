using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkmTCG
{
    class PkmCard : Card
    {
        Attack a1;
        Attack a2;
        Effect pkmPower;
        String desc;

        private PkmCard(String name, Rarity thisRare, int setNum, int id) : base(name, thisRare, setNum, id)
        {
           
        }
    }
}

