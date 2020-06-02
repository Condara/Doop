using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP_LV6_Čondić.NSObserver
{
    public interface WeatherObserver
    {
        void Update(int temperature);
    }
}
