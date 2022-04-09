using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBL.Dataclass
{
    enum FBLer
    {
        None = 0,
        Consumer = 1,
        Carrier = 1 << 1,
        Looper = Consumer | Carrier
    }
}
