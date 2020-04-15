using System;
using System.Collections.Generic;
using System.Text;

namespace Numero4
{
    class Packing : Memory, States
    {
        public Packing(int memory, int Storagememory, int Speed) 
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

            Console.WriteLine("Packing on");
        }
        public void off()
        {
            Console.WriteLine("Packing off");
        }
        public void reboot()
        {
            Console.WriteLine("Packing rebooting");
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
