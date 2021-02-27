using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Class
{
    public class GlobalsMaNV
    {
        public static int GlobalMaNV { get; private set; }
        public static void SetGlobalMaNV(int prid)
        {
            GlobalMaNV = prid;
        }
    }
}
