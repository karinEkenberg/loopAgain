/*
Övning 8: Skapa ett program där användaren får svara på frågan ”Vilket är Europas folkrikaste
land?”. Användaren får maximalt 5 chanser på sig att svara. När användaren svarar rätt så ska
programmet skriva ut att rätt svar angavs, därefter ska det avslutas. Utnyttja ett break
någonstans i din loop.
 */

namespace loopAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoopAgain.WhatCountry();
        }
    }

    class LoopAgain()
    {
        public static void WhatCountry()
        {
                for (int i = 0; i < 5; i++) 
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("Which country in Europe is the most populous? Press X to exit.");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "RUSSIA")
                    {
                        Console.WriteLine("Congratulatios you are right!");
                        break;
                    }
                    else if (answer == "X")
                    {
                        Console.WriteLine("Shutting down, thanks for this time!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong, try again!");
                        continue;
                    }
                }
            
        }
    }
}
