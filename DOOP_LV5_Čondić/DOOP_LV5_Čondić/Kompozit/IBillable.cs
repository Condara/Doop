using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP_LV5_Čondić.Kompozit
{
    interface IBillable
    {
        double Price { get; }
        string Description(int depth = 0);
    }

}