using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public interface ISpeed
    {
        int Speed { get; set; }
        void Run();
    }
}
