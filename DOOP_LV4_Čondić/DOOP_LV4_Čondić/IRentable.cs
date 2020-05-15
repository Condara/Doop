using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP_LV4_Čondić
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
