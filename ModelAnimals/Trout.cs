using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    class Trout:Fish,ISwim
    {
        public Trout(string name) : base(name)
        {

        }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void Swim()
        {
            Console.WriteLine($"I am {Name} and I can swim with maximum speed {Speed} km/h.");
        }
    }
}
