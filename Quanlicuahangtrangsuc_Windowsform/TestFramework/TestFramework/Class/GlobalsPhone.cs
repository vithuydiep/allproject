using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Class
{
    public class GlobalsPhone
    {
        public static string GlobalPhone { get; private set; }
        public static void SetGlobalsPhone(string prid)
        {
            GlobalPhone = prid;
        }
    }
}
