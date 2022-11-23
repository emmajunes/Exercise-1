using System;
using System.Diagnostics;

namespace Exercise_1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            
            var stopwatch = new Stopwatch();
            

            while (true)
            {
                Console.WriteLine("Tap 'y' to start, 'n' to stop, or 'q' to quit.");
                //var character = Console.ReadLine();

                
                switch (Console.ReadLine())
                {
                    case "y":
                            Console.WriteLine("start");
                            stopwatch.Start(); 
                   
                        break;
                    case "n":
                        Console.WriteLine("stop");
                        Console.WriteLine(stopwatch.Stop());
                       
                        break;
                    case "q":
                        return;
                }
            }
        }
    }
}