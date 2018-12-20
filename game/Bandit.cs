using System;


namespace game
{
    class Bandit : Enemy
    {
        public Bandit(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
            numOfAttack = 2;
        }


        public void Steal(Hero target)
        {
            target.health -= attack + 2;
        }

        public void BanditTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Bandit vous a frappé!");

            }

            if (choice == 2)
            {
                Steal(target);
                Console.WriteLine("Bandit vous a volé!");

            }

            Console.ReadLine();
            Console.Clear();
        }

    }
}
