using System;

namespace ModelAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammals mammals = new Mammals("Platypus");
            mammals.Speed = 3;
            mammals.Run();
            Fish fish = new Fish("Trout");
            fish.Speed = 50;
            fish.Run();
            Birds birds = new Birds("Wild Duck");
            birds.Speed = 15;
            birds.Run();
            Reptile reptile = new Reptile("Snake");
            reptile.Speed = 5;
            reptile.Run();
            Insects insects = new Insects("Butterfly");
            insects.Speed = 10;
            insects.Run();
        }
    }
}
