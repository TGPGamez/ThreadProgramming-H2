using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadProgramming_H2
{
    class Øvelse_0
    {
        public void Start()
        {
            //Making instance of a thread with method
            Thread thread = new Thread(WorkThreadFunction);
            Thread thread2 = new Thread(WorkThreadFunction);
            thread.Name = "1";
            thread2.Name = "2";
            //Start the thread
            thread.Start($"[{thread.Name}] Simple Thread");
            thread2.Start($"[{thread2.Name}] Simple Thread");
            Console.Read();
        }

        private void WorkThreadFunction(object obj)
        {
            //Write to console 5 times
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
