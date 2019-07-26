using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    class Bat:Mammals,IFly
    {
        public Bat(string name) : base(name)
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
    }
}
