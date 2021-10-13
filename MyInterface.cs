using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretance
{
    interface IAutomobile<T>
    {
        bool Equals(T obj);
    }
}
