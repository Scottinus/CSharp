using System;

namespace HeroProject
{
    class Program
    {
        static void Main(string[] args)
        {

            HeroFactory heroFactory = new HeroFactory();
            Hero hero = null;
            Console.WriteLine("----STRIVE RPG-----");
            Console.WriteLine("Choose your Hero: Bard, Mage, Warrior");
            string classTaken = Console.ReadLine();
            hero = heroFactory.HeroClass(classTaken);

            if (hero != null)
            {
                startPlay(hero);
            }


        }

        public static void startPlay(Hero hero)
        {

            hero.chosenHero();
            hero.heroAttack();
        }
    }
}
