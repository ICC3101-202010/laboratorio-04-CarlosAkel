using System;
using System.Collections.Generic;
using System.Text;

namespace Numero4
{
    class Reception : Memory, States
    {
        public Reception(int memory, int Storagememory,int Speed)
        {
            this.memory = memory;
            this.Storagememory = Storagememory;
            this.Speed = Speed;
        }
        public override void run()
        {
            for (int i = 0; i < Speed; i++)
            {
                Storagememory++;
                if (Storagememory == memory)
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("memory is in max Capacity");
                    reboot();
                }
            }

        }
        public void on()
        {
            Console.WriteLine("Reception on");
        }
        public void off()
        {
            Console.WriteLine("Reception off");
        }
        public void reboot()
        {
            Console.WriteLine("Reception rebooting");
            memory = 0;
        }
        public bool Manualreboot()
        {
            for (int i = 0; i < Speed; i++)
            {
                Storagememory++;
                if (Storagememory == memory)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
