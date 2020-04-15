using System;
using System.Collections.Generic;
using System.Text;

namespace Numero4
{
    interface States
    {
        void on();
        void off();
        void reboot();
        bool Manualreboot();

    }
}
