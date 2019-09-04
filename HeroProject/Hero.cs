using System;
using System.Collections.Generic;
using System.Text;

namespace HeroProject
{
    public abstract class Hero
    {
        private string name;
        private string attackType;
        private string spell;
        private double damage;

        public string getName() {
            return name; }

        public void  setName(string newName) {

            name = newName;
        }


        public  string getAttackType() { return attackType; }
        public void setAttackType(string newAttack) { attackType = newAttack; }

        public string getSpell() { return spell; }
        public void setSpell(string newSpell) { spell = newSpell; }

        public double getDamage() { return damage; }
        public void setDamage(double newDamage) { damage = newDamage; }


        public void chosenHero()
        {
            Console.WriteLine("Your Hero class is:  " + getName());
        }
        public void heroAttack()
        {
            Console.WriteLine(getName() + " uses a: " + getAttackType() +  " attack - " + getSpell() + " - Damage: " + getDamage()) ;
        }

    }
}
