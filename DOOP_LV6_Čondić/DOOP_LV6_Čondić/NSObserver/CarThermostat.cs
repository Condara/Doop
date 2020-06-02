using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP_LV6_Čondić.NSObserver
{
    class CarThermostat : WeatherObserver
    {
        int bhp = 77;
        bool WinterTires = false;
        const int TireChangeThreshold = 5;

        public void Update(int temperature)
        {
            this.WinterTires = temperature <= 5 ? true : false;
            string tires = WinterTires ? "Zimske gume" : "Ljetne gume";
            Console.WriteLine(tires);
        }
    }
}
