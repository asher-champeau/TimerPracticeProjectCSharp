using System;

namespace TimerPractice
{
    class Program
    {
       
        
        
        static void Main(string[] args)
        {
            
            TimerGuts timer = new TimerGuts();
            string userInput = "";
            string quitInput = "";

            while (quitInput != "q" && quitInput != "Q")
            {
                while (!timer.Finished() && (quitInput != "q" && quitInput != "Q"))
                {
                    Console.WriteLine("< Timer >\nM for minutes\nS for seconds\nQ to quit");
                    Console.Write("> ");
                    userInput = Console.ReadLine();
                    

                    if (userInput == "S" || userInput == "s")
                    {
                        Console.WriteLine("Enter a time for your timer in seconds:");
                        float duration = timer.UserInput();
                        timer.RunSeconds(duration);
                        //Console.WriteLine("Timer Finished.");
                        Console.Write("Press Enter to start another timer or enter q to quit: ");
                        Console.Write("> ");
                        quitInput = Console.ReadLine();
                        Console.Clear();
                    }

                    else if (userInput == "M" || userInput == "m")
                    {
                        Console.WriteLine("Enter a time for your timer in minutes:");
                        float duration = timer.UserInput();
                        timer.RunMinutes(duration);
                        //Console.WriteLine("Timer Finished.");
                        Console.Write("Press Enter to start another timer or enter q to quit: ");
                        Console.Write("> ");
                        quitInput = Console.ReadLine();
                        Console.Clear();
                    }
                    else if (userInput == "q" || userInput == "Q")
                    {
                        quitInput = "q";
                        
                    }
                    else
                    { 
                        Console.WriteLine("Invalid input."); 
                    }
                  
                }
            }
        }

        
    }
}
