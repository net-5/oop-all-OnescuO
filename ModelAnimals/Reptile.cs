using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Reptile
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public Reptile(string name) 
        {
            Name = name;
            
        }
        

    }
}
