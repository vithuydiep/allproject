﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class Globals
    {
        public static int GlobalUserId { get; private set; }
        public static void SetGlobalUserId(int userid)
        {
            GlobalUserId = userid;
        }
    }
}
