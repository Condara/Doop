using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP_LV4_Čondić.Fasada
{
    interface IEmailValidatorService
    {
        bool IsValidAddress(String candidate);
    }
}

