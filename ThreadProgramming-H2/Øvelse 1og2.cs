using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadProgramming_H2
{
    class Øvelse_1og2
    {
        public void Start()
        {
            Thread thread = new Thread(ThreadOutput);
            Thread thread2 = new Thread(ThreadOutput);
            thread.Name = "1";
            thread2.Name = "2";
            thread.Start($"[{thread.Name}] C#-trådning er nemt!");
            thread2.Start($"[{thread2.Name}] også med flere tråde...");
            
        }

        private void ThreadOutput(object obj)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(obj);
                Thread.Sleep(1000);
            }
        }
    }
}
