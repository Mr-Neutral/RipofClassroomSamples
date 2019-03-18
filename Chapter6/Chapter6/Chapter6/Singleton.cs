using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter6
{
    public static class Singleton
    {
        static Singleton()
        {
            StartupTime = DateTime.Now; 
        }

        public static DateTime StartupTime { get; set; }
    }
}
