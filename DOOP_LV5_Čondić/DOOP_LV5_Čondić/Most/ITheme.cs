using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP_LV5_Čondić.Most
{
    interface ITheme
    {
        void SetBackgroundColor();
        void SetFontColor();
        string GetHeader(int width);
        string GetFooter(int width);
    }
}
