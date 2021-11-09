using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations.Interfaces
{
    public interface IBuyer
    {
        string Name { get;  }
        int Food { get; }

        void Buyfood();
    }
}
