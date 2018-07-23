using System;
using System.Threading;

namespace Ch01
{
    class _4ThreadPool
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Execution!!!");

            CreateThreadUsingThreadPool();

            Console.WriteLine("Finish Execution");
            Console.ReadLine();
        }

        private static void CreateThreadUsingThreadPool()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(PrintNumber10Times));
        }
            
        private static void PrintNumber10Times(object state)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(1);
            }
            Console.WriteLine();
        }
    }
}

//static void Main(string[] args)
//{
//    Console.WriteLine("Start Execution!!!");

//    //Uncomment for synchronous behavior
//    // PrintNumber10Times();

//    //Using Thread without parameter
//    CreateThreadUsingThreadClassWithoutParameter();

//    //Using Thread with parameter
//    CreateThreadUsingThreadClassWithParameter();

//    Console.WriteLine("Finish Execution");
//    Console.ReadLine();
//}
//private static void PrintNumber10Times()
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.Write(1);
//    }
//    Console.WriteLine();
//}


//private static void CreateThreadUsingThreadClassWithoutParameter()
//{
//    System.Threading.Thread thread;
//    thread = new System.Threading.Thread(new System.Threading.ThreadStart(PrintNumber10Times));
//    thread.Start();
//}