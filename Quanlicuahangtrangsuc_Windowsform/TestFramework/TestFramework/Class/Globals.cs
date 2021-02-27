using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    class Globals
    {
        public static int GlobalProductId { get; set; }
        public static void SetGlobalProductId(int prid)
        {
            GlobalProductId = prid;
        }
    }
}
