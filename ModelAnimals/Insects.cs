using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Insects: Animals, ISpeed
    {
        public Insects(string name) : base(name)
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
            if(Name == "Butterfly")
            {
                Console.WriteLine($"I am a {Name} and I can fly with {Speed} km/h.");
            }
        }
    }
}
