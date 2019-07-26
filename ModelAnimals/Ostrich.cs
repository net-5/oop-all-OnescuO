using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    class Ostrich:Birds, IWalk
    {
        public Ostrich(string name) : base(name)
        {

        }

        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void Walk()
        {
            Console.WriteLine($"I am {Name} and I can walk with maximum speed {Speed} km/h.");
        }
    }
}
