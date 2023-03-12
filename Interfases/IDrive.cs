using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interfases
{
    internal interface IDrive
    {
        public void TurnRight();
        public void TurnLeft();
        public IDrive ReturnSelf();

        public static bool Light;
        public static void Click()
        {
            Light = !Light;
        }
        static IDrive()
        {
            Console.WriteLine("Static ctor from IDrive");
            Light = false;
        }
    }
}
