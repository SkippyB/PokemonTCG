using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkmTCG
{
    class pkmCard : Card
    {
        Attack a1;
        Attack a2;
        Effect pkmPower;
        String desc;

        private pkmCard(String name, int id) : base(name, id)
        {
           
        }



    }
}
