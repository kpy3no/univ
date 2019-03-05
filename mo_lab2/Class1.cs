using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mo_lab2
{
    class Class1
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int milliseconds = 0;

        private static void TimerEventProcessor(Object myObject,
                                                EventArgs myEventArgs)
        {
            milliseconds += 1;
        }
    }
}
