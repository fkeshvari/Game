
using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Avant de commencer le jeux, entrez votre nom :");
            string name = Console.ReadLine();

            Hero Dash = new Hero(name, 3, 15);

            Bandit Keith = new Bandit("Bandit Keith", 1, 5);
            Bandit Ben = new Bandit("Bandit Ben", 2, 8);

            Chevalier Leeroy = new Chevalier("Knight Leeroy", 3, 12);
            Chevalier Seth = new Chevalier("Knight Seth", 5, 15);

            Dragon BlueDrag = new Dragon("Blue Dragon", 7, 20, 2);
            Dragon RedDrag = new Dragon("Red Dragon", 8, 20, 3);
            Dragon BlackDrag = new Dragon("Black Dragon", 10, 25, 4);

            Histoire.BeforeBandits();
            Attack.WithBandit(Dash, Keith);
            Attack.WithBandit(Dash, Ben);

            Dash.LevelUp();

            Histoire.BeforeKnights();
            Attack.WithKnight(Dash, Leeroy);
            Attack.WithKnight(Dash, Seth);

            Dash.LevelUp();

            Histoire.BeforeDragons();
            Attack.WithDragon(Dash, BlueDrag);
            Attack.WithDragon(Dash, RedDrag);
            Attack.WithDragon(Dash, BlackDrag);

            Histoire.TheEnd();


        }
    }
}
