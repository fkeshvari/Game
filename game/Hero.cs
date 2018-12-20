using System;

namespace game
{
    class Hero : Person
    {
        public int healLvl = 7, maxHealth = 15;

        public Hero(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
        }

        public void LevelUp()
        {
            Console.WriteLine("Vous êtes passé à un niveau suivant !");
            Console.WriteLine("Attaque +3");
            Console.WriteLine("Santé maximale +10");
            Console.WriteLine("Soin +5");
            Console.ReadLine();
            Console.Clear();

            attack += 3;
            maxHealth += 10;
            health = maxHealth;
            healLvl += 5;
        }


        public void Heal()
        {
            health += healLvl;

            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }

        public void SpinAttack(Enemy target)
        {
            target.health -= ((attack - 2) * 3);
        }

        public void DoubleSlash(Enemy target)
        {
            target.health -= attack * 2;
        }


        public int Choice() 
        {
            bool correctInput = true;
            int choice = 0, choice2;
            while (correctInput)
            {
                Console.WriteLine("Qu'est-ce que vous aimeriez faire?");
                Console.WriteLine("1. Attaquer");
                Console.WriteLine("2. Potion");
                Console.WriteLine("3. Spécial");

                bool test = int.TryParse(Console.ReadLine(), out choice);
                if (!test || choice > 3 || choice <= 0)
                {
                    Console.WriteLine("Ce n'est pas l'une des options! Réessayer!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (choice == 3) 
                {
                    Console.WriteLine("Choisir Spécial:");
                    Console.WriteLine("1. Attaque de spin");
                    Console.WriteLine("2. double slash");
                    Console.WriteLine("3. <--- retourner");

                    bool test2 = int.TryParse(Console.ReadLine(), out choice2);
                    if (!test2 || choice2 > 3 || choice2 <= 0)
                    {
                        Console.WriteLine("Ce n'est pas l'une des options! Réessayer!");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (choice2 == 1)
                    {
                        choice = 4;
                    }

                    if (choice2 == 2)
                    {
                        choice = 5;
                    }
                }

                if (choice == 1 || choice == 2 || choice == 4 || choice == 5)
                {
                    break;
                }
            }
            return choice;
        }

        public void YourTurn(int decision, Enemy target)
        {
            if (decision == 1)
            {
                NormAttack(target);
                Console.WriteLine("Vous avez donné un coup de pied à l'ennemi!");
            }

            if (decision == 2)
            {
                Heal();
                Console.WriteLine("Vous avez guéri de {0} points de vie!", healLvl);
            }

            if (decision == 4)
            {
                SpinAttack(target);
                Console.WriteLine("Vous avez utilisé une attaque de spin!");
            }

            if (decision == 5)
            {
                DoubleSlash(target);
                Console.WriteLine("Vous avez utilisé double slash!");
            }

        }
    }

}
    
