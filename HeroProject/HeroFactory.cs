using System;
using System.Collections.Generic;
using System.Text;

namespace HeroProject
{
    class HeroFactory
    {

        public Hero HeroClass(string newHero)
        {
            Hero hero = null;
            if (newHero.ToLower() == "bard")
            {
                return new BardHero();
            }
            else
                if (newHero.ToLower() == "mage")
            {
                return new MageHero();
            }
            else
                if (newHero.ToLower() == "warrior")
            {
                return new WarriorHero();
            }
            else
                return null;
           
        }
    }
}
