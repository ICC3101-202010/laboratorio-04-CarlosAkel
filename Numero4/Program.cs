using System;

namespace Numero4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Reception R = new Reception(15,0, random.Next(1, 31));//memory,StorageCapacity, Speed(How many ticks for one day) 
            Storage S = new Storage(15, 0, random.Next(1, 31));//podria hacer un random
            assembly A = new assembly(15, 0, random.Next(1, 31));
            Verification V = new Verification(15, 0, random.Next(1, 31));
            Packing P = new Packing(15, 0, random.Next(1, 31));
            Console.WriteLine("Manual or Auto (0/1)");
            int ans = Int32.Parse(Console.ReadLine());
            if (ans == 0)
            {
                R.on();
                S.on();
                A.on();
                V.on();
                P.on();
                Console.WriteLine("   ");
                string[] Names = { "Reception", "Storage", "assembly", "Verification", "Packing" };
                bool[] lista = { R.Manualreboot(), S.Manualreboot(), A.Manualreboot(), V.Manualreboot(), P.Manualreboot() };
                for (int i = 0; i < 5; i++)
                {
                    if (lista[i] == true)
                    {
                        Console.WriteLine("Memory of " + Names[i] + " is full " );
                        Console.WriteLine("Which one do you want to reboot?");
                        Console.WriteLine("Reception, Storage, assembly, Verification, Packing /(0,1,2,3,4)");
                        int options = Int32.Parse(Console.ReadLine());
                        if (options == 0)
                        {
                            R.reboot();
                        }
                        else if (options == 1)
                        {
                            S.reboot();
                        }
                        else if (options == 2)
                        {
                            A.reboot();
                        }
                        else if (options == 3)
                        {
                            V.reboot();
                        }
                        else if (options == 4)
                        {
                            P.reboot();
                        }

                        if(options != i)
                        {
                            Console.WriteLine("Memory of "+ Names[i]+" still  full stoping "+ Names[i] +" process");
                        }
                    }
                }


                R.off();
                S.off();
                A.off();
                V.off();
                P.off();
            }
            else
            {
                R.on();
                S.on();
                A.on();
                V.on();
                P.on();


                R.run();
                S.run();
                A.run();
                V.run();
                P.run();

                Console.WriteLine("   ");
                R.off();
                S.off();
                A.off();
                V.off();
                P.off();
            }

        }
    }
}
