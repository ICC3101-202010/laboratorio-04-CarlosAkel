using System;
using System.Collections.Generic;
using System.Text;

namespace Numero4
{
    abstract class Memory
    {
        protected int memory { get; set; }
        protected int Storagememory { get; set; }
        protected int Speed { get; set; }
        public abstract void run();
    }
}
