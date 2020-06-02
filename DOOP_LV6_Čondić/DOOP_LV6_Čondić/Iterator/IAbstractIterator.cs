using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP_LV6_Čondić.Iterator
{
    interface IAbstractIterator
    {
        note First();
        note Next();
        bool IsDone { get; }
        note Current { get; }
    }
}
