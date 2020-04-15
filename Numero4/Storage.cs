using System;
using System.Collections.Generic;
using System.Text;

namespace Numero4
{
    class Storage : Memory, States
    {
        public Storage(int memory, int Storagememory, int Speed)
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
            Console.WriteLine("Storage on");
        }
        public void off()
        {
            Console.WriteLine("Storage off");
        }
        public void reboot()
        {

            Console.WriteLine("Storage rebooting");
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
