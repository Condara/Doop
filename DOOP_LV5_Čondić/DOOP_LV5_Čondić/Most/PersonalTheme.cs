﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP_LV5_Čondić.Most
{
    class PersonalTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public string GetHeader(int width)
        {
            return new string('+', width);
        }
        public string GetFooter(int width)
        {
            return new string('_', width);
        }
    }
}
