using System;

namespace ModelAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            WildDuck wildDuck = new WildDuck("Wild Duck");
            wildDuck.Speed = 30;
            wildDuck.Fly();
            wildDuck.Speed = 20;
            wildDuck.Swim();
            wildDuck.Speed = 10;
            wildDuck.Walk();

            Ostrich ostrich = new Ostrich("Ostrich");
            ostrich.Speed = 35;
            ostrich.Walk();

            Butterfly butterfly = new Butterfly("Butterfly");
            butterfly.Speed = 5;
            butterfly.Fly();

            Snake snake = new Snake("Snake");
            snake.Speed = 2;
            snake.Crawl();

            Platypus platypus = new Platypus("Platypus");
            platypus.Speed = 10;
            platypus.Swim();
            platypus.Speed = 6;
            platypus.Walk();

            Bat bat = new Bat("Bat");
            bat.Speed = 50;
            bat.Fly();

            Trout trout = new Trout("Trout");
            trout.Speed = 100;
            trout.Swim();
            
        }
    }
}
