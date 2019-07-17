using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Mammals: Animals, ISpeed
    {
        private int speed;
        public Mammals(string name) : base(name)
        {

        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void Run()
        {
            if(Name == "Platypus")
            {
                
                Console.WriteLine($"I am a {Name} and i walk and swim with {Speed} km/h.");
            }
            
        }
    }
}
