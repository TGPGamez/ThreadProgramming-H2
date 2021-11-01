using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadProgramming_H2
{
    class Øvelse_4
    {
        private char inputChar;
        public void Start()
        {
            inputChar = '*';
            Thread printer = new Thread(Printer);
            Thread reader = new Thread(Reader);
            printer.Start();
            reader.Start();
        }

        private void Printer()
        {
            while(true)
            {
                Console.Write(inputChar);
                Thread.Sleep(50);
            }
        }

        private void Reader()
        {
            while (true)
            {
                string result = Console.ReadLine();
                if (result != null)
                {
                    inputChar = result[result.Length - 1];
                }
            }
        }
    }
}
