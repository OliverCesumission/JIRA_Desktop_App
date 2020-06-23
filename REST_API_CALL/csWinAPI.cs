﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace REST_API_CALL
{
    class csWinAPI
    {
        public const int HOR_POSITIVE = 0X1;
        public const int HOR_NEGATIVE = 0X1;
        public const int VER_POSITIVE = 0X1;
        public const int VER_NEGATIVE = 0X1;
        public const int BLEND = 0X80000;
        public const int CENTER = 0X10;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        public static extern int AnimateWindow(IntPtr hwand,int dwTime, int dwFlag);
    }
}
