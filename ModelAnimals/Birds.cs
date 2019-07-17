using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Birds: Animals, ISpeed
    {
        public Birds(string name) : base(name)
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
            if(Name == "Wild Duck")
            {
                int speed2 = 20;
                int speed3 = 10;
                Console.WriteLine($"I am a {Name} and I can swim with {Speed} km/h and fly with {speed2} km/h and walk with {speed3} km/h.");
            }
        }
    }
}
