using System;


namespace game
{
    class Chevalier : Enemy
    {
        public Chevalier(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
            numOfAttack = 3;
        }


        public void Slash(Hero target)
        {
            target.health -= attack + 5;
        }

        public void SheildSlam(Hero target)
        {
            target.health -= attack + 2;
        }

        public void KnightTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Chevalier vous a frappé!");
            }

            if (choice == 2)
            {
                Slash(target);
                Console.WriteLine("Chevalier vous a sarbré!");
            }

            if (choice == 3)
            {
                SheildSlam(target);
                Console.WriteLine("Chevalier vous a claqué avec son bouclier!");
            }

            Console.ReadLine();
            Console.Clear();
        }

    }
}
