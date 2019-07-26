using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    class Snake:Reptile,ICrawl
    {
        public Snake(string name) : base(name)
        {

        }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public void Crawl()
        {
            Console.WriteLine($"I am {Name} and I can crawl with maximum speed {Speed} km/h.");
        }
    }
}
