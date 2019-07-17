using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Animals
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public Animals(string name)
        {
            Name = name;
        }
    }
}
