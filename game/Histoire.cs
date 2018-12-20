using System;


namespace game
{
    class Histoire
    {
        public static void BeforeBandits()
        {
            Console.WriteLine("Vous êtes sur votre chemin pour tuer les dragons qui détruisent le royaume");
            Console.WriteLine("Quand vous vous dirigez vers les repaires des dragons, vous rencontrez quelques bandits.");
            Console.WriteLine("Et ils ne semblent pas gentils...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void BeforeKnights()
        {
            Console.WriteLine("Les bandits ne vous correspondaient pas beaucoup. Bien joué! Vous continuez vers le repaire des dragons!");
            Console.WriteLine("Cependant, un nouveau mouvement est né qui veut protéger les dragons du monde.");
            Console.WriteLine("De nombreuses personnes ont rejoint ce mouvement, y compris des chevaliers.");
            Console.WriteLine("Et euh oh, il y en a deux qui ont découvert votre quête.");
            Console.WriteLine("Peut-être qu'ils sont gentils?");
            Console.ReadLine();
            Console.WriteLine("Non!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void BeforeDragons()
        {
            Console.WriteLine("Avec les chevaliers vaincus, vous continuer votre voyage!.");
            Console.WriteLine("Au bout d'un moment, vous vous dirigez vers le repaire des dragons...");
            Console.WriteLine("Il fait chaud ici.");
            Console.WriteLine("Mais le moment est venu de mettre fin au saccage des dragons!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void TheEnd()
        {
            Console.WriteLine("Vous avez tué les dragons et sauvé le royaume!");
            Console.WriteLine("Félicitations!");
            Console.ReadLine();
        }


    }
}
