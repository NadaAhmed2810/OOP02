using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    [Flags]
    internal enum Security
    {
      Guest=1, 
      Developer=2,
      Secretary=4,
      DBA=8
    }
}
