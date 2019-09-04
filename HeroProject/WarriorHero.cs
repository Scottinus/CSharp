using System;
using System.Collections.Generic;
using System.Text;

namespace HeroProject
{
    class WarriorHero : Hero
    {
        public WarriorHero()
        {
            setName("Warrior");
            setAttackType("Physic");
            setSpell("Heavy Slash");
            setDamage(30.0);
        }
    }
}