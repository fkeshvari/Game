﻿using System;


namespace game
{
    class Attack
    {
        public static void IsHeroDead(Hero hero)
        {
            if (hero.health <= 0)
            {
                Console.Clear();
                Console.WriteLine("Il semble que vous êtes mort");
                Console.WriteLine("Bonne chance pour la prochaine fois!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public static void PrintTheStats(Person person1, Person person2)
        {
            person1.PrintStats();
            Console.WriteLine("");
            person2.PrintStats();
            Console.WriteLine("");
        }

        public static void WithBandit(Hero hero, Bandit bandit)
        {
            while (bandit.health > 0 && hero.health > 0)
            {
                PrintTheStats(bandit, hero);

                hero.YourTurn(hero.Choice(), bandit);

                if (bandit.health > 0)
                {
                    bandit.BanditTurn(bandit.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} a été tué!", bandit.name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithKnight(Hero hero, Chevalier knight)
        {
            while (knight.health > 0 && hero.health > 0)
            {
                PrintTheStats(knight, hero);

                hero.YourTurn(hero.Choice(), knight);

                if (knight.health > 0)
                {
                    knight.KnightTurn(knight.EChoice(), hero);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine("{0} a été tué!", knight.name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithDragon(Hero hero, Dragon dragon)
        {
            while (dragon.health > 0 && hero.health > 0)
            {
                PrintTheStats(dragon, hero);

                hero.YourTurn(hero.Choice(), dragon);

                if (dragon.health > 0)
                {
                    dragon.DragonTurn(dragon.EChoice(), hero);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine("{0} a été tué !", dragon.name);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
