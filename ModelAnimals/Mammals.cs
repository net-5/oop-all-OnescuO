using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Mammals
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        
        public Mammals(string name) 
        {
            Name = name;
            
        }

       
    }
}
