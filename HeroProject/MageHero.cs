using System;
using System.Collections.Generic;
using System.Text;

namespace HeroProject
{
    class MageHero : Hero
    {
        public MageHero()
        {
            setName("Mage");
            setAttackType("Magic");
            setSpell("FireBall");
            setDamage(20.0);
        }
    }
}