using System;
using System.Collections.Generic;
using System.Text;

namespace HeroProject
{
    class BardHero: Hero
    {
        public BardHero()
        {
            setName("Bard");
            setAttackType("Magic");
            setSpell("Dancing Lights");
            setDamage(10.0);
        }
    }
}
