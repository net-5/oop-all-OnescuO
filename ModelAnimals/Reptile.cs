using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Reptile: Animals, ISpeed
    {
        public Reptile(string name) : base(name)
        {

        }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void Run()
        {
            if(Name == "Snake")
            {
                Console.WriteLine($"I am a {Name} and i crawl with {Speed} km/h.");
            }
        }
    }
}
