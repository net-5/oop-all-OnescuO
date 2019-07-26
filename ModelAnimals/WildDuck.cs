using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    class WildDuck: Birds, IFly,ISwim,IWalk
    {
        public WildDuck(string name) : base(name)
        {

        }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void Fly()
        {
            Console.WriteLine($"I am {Name} and I can fly with maximum speed {Speed} km/h.");
        }

        public void Swim()
        {
            Console.WriteLine($"I am {Name} and I can swim with maximum speed {Speed} km/h.");
        }

        public void Walk()
        {
            Console.WriteLine($"I am {Name} and I can walk with maximum speed {Speed} km/h.");
        }
    }
}
