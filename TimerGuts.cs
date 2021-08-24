using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TimerPractice
{
    class TimerGuts
    {
        #region Variables

        bool running = false;
        bool started = false;

        #endregion

        #region Properties
        public float Duration
        {
            set
            { float duration; }
            
        }

        public void MainMenu()
        {
            Console.Clear();
            string mMenu = "Timer! \n Enter a duration for your timer in seconds: ";
            Console.Write(mMenu);
     
        }

        public float UserInput()
        {
            string input = Console.ReadLine();
            bool isNum = Double.TryParse(input, out double result);
            
            if (isNum)
            {
                Console.Clear();
                Console.WriteLine("You picked " + (float)result);
                return (float)result;
            }

            else
            {
                Console.WriteLine("Words aren't numbers.");
                return -1;
            }
        }

        public bool RunSeconds(float duration = 0)
        {
            if (duration < 0)
            {
                return false;
            }
            float tick = 0;
            Console.Write("Press Enter to start timer.");
            Console.ReadLine();
            while (duration > tick)
            {
                started = true;
                running = true;
                Thread.Sleep(1000);
                tick += 1;
                Console.WriteLine(tick + " second(s)");
                
            }
            if (duration <= tick)
            {
                running = false;
                int beeps = 0;
                int level = 800;
                float afterTick = 0;
                Console.WriteLine("Press any key to stop alarm.");
                while (Console.KeyAvailable == false)
                //while (beeps != 10)
                {
                    Console.Beep(level, 500);
                    //level += 50;
                    //Thread.Sleep(500);
                    Console.Beep(level + 100, 500);
                    //Thread.Sleep(500);
                    beeps += 1;
                    afterTick += 1;
                    Console.WriteLine(tick + " second timer finished for " + afterTick + " seconds.");
                }
                Console.ReadLine();
                Console.Clear();
                return false;
            }
            else
            {
                return true;
            }


        }

        public bool RunMinutes(float duration = 0)
        {
            if (duration < 0)
            {
                return false;
            }
            duration *= 60;
            float tick = 0;
            Console.Write("Press Enter to start timer.");
            Console.ReadLine();
            while (duration > tick)
            {
                started = true;
                running = true;
                Thread.Sleep(1000);
                tick += 1;
                Console.WriteLine(tick + " second(s)");

            }
            if (duration <= tick)
            {
                running = false;
                int beeps = 0;
                int level = 800;
                float afterTick = 0;
                Console.WriteLine("Press any key to stop alarm.");
                while (Console.KeyAvailable == false)
                //while (beeps != 10)
                {
                    Console.Beep(level, 500);
                    //level += 50;
                    // Thread.Sleep(500);
                    Console.Beep(level + 100, 500);
                    // Thread.Sleep(500);
                    beeps += 1;
                    afterTick += 1;
                    Console.WriteLine(tick / 60 + " minute timer finished for " + afterTick / 60 + " minutes.");
                }
                Console.ReadLine();
                Console.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Finished()
        {
            if (started == true && running == false)
            {
                started = false;                
                return true;

            }
            else
            {
                return false;
            }
        }
        #endregion

    }
}
