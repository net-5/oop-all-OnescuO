using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Fish: Animals, ISpeed
    {
        public Fish(string name) : base(name)
        {

        }
        private int speed;
        public  int Speed
        { get { return speed; }
            set { speed = value; }
        }

        public void Run()
        {
            if(Name == "Trout")
            {
                Console.WriteLine($"I am a {Name} and I swim with {Speed} km/h.");
            }
        }
    }
}
