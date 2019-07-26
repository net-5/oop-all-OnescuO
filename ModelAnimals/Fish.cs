using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Fish
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public Fish(string name)
        {
            Name = name;
            
        }
        
       
    }
}
