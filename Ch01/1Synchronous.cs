using System;

namespace Ch01
{
    class _1Synchronous
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Execution!!!");
                        
            PrintNumber10Times();

            Console.WriteLine("Finish Execution");
            Console.ReadLine();
        }
        private static void PrintNumber10Times()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(1);
            }
            Console.WriteLine();
        }
    }
}
