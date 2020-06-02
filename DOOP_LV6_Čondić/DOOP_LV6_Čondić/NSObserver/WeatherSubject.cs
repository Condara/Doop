using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP_LV6_Čondić.NSObserver
{
    public interface WeatherSubject
    {
        void AddObserver(WeatherObserver weatherObserver);
        void RemoveObserver(WeatherObserver weatherObserver);
        void Notify();
    }
}