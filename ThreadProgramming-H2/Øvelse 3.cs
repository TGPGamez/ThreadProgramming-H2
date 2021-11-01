using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadProgramming_H2
{
    class Øvelse_3
    {
        private int alarms;
        public void Start()
        {
            alarms = 0;
            Thread tempThread = new Thread(TempMethod);
            Thread tempAlive = new Thread(SeeIfTempThreadIsAlive);
            tempThread.Name = "Temp Thread";
            tempAlive.Name = "Temp Alive";
            tempThread.Start();
            tempAlive.Start(tempThread);
        }

        private void TempMethod()
        {
            while (alarms < 3)
            {
                int temp = GenerateTemp();
                Console.WriteLine($"Temperatur: {temp} C");
                if (temp < 0 || temp > 100)
                {
                    alarms++;
                    Console.WriteLine("[ALARM] Temperatur uden for lovligt interval.");
                }
                Thread.Sleep(300);
            }
        }

        private void SeeIfTempThreadIsAlive(object obj)
        {
            Thread check = (Thread)obj;
            while (check.IsAlive)
            {
                Thread.Sleep(10000);
            }
            Console.WriteLine("[ALARM] Alarm-tråd termineret!");
        }


        private int GenerateTemp()
        {
            return new Random().Next(-20, 120);
        }
    }
}
