using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ch09
{
    class _2ExceptionHandling
    {
        //public static void Main()
        //{
        //    // AsyncReturningValueExample();
        //    Console.WriteLine("Main Method Startes");
        //    // var task = Scenario1CallAsyncWithoutAwaitFromInsideTryCatch();
        //    var task = Scenario2CallAsyncWithoutAwaitFromInsideTryCatch();
        //    if (task.IsFaulted)
        //        Console.WriteLine(task.Exception.Flatten().Message.ToString());
        //    Console.WriteLine("In Main Method After calling method");
        //    Console.ReadLine();
        //}

        public static void Main()
        {
            Console.WriteLine("Main Method Startes");
            //var task = Scenario1CallAsyncWithoutAwaitFromOutsideTryCatch();
            //if (task.IsFaulted)
            //    Console.WriteLine(task.Exception.Flatten().Message.ToString());

            //var task = Scenario2CallAsyncWithoutAwaitFromInsideTryCatch();
            //if (task.IsFaulted)
            //    Console.WriteLine(task.Exception.Flatten().Message.ToString());

            //var task = Scenario3CallAsyncWithAwaitFromOutsideTryCatch();
            //if (task.IsFaulted)
            //    Console.WriteLine(task.Exception.Flatten().Message.ToString());


            Scenario4CallAsyncWithoutAwaitFromOutsideTryCatch();

            Console.WriteLine("In Main Method After calling method");
            Console.ReadLine();
        }

        private async static void Scenario4CallAsyncWithoutAwaitFromOutsideTryCatch()
        {
            Task task = DoSomethingFaulty();
            Console.WriteLine("This should not execute");          
        }

        private async static Task Scenario3CallAsyncWithAwaitFromOutsideTryCatch()
        {
            await DoSomethingFaulty();
            Console.WriteLine("This should not execute");           
        }
        private async static Task Scenario2CallAsyncWithoutAwaitFromInsideTryCatch()
        {
            try
            {
                var task = DoSomethingFaulty();
                Console.WriteLine("This should not execute");
                task.ContinueWith((s) =>
                {
                    Console.WriteLine(s);
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        private async static Task Scenario2AsyncReturningTaskExample()
        {
            try
            {
                Task task = DoSomethingFaulty();
                Console.WriteLine("This should not execute");
                task.ContinueWith((s) =>
                {
                    Console.WriteLine(s);
                });
                // Console.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        private async static Task Scenario1CallAsyncWithoutAwaitFromOutsideTryCatch()
        {
            Task task = DoSomethingFaulty();
            Console.WriteLine("This should not execute");
            try
            {
                task.ContinueWith((s) =>
                {
                    Console.WriteLine(s);
                });
                // Console.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private async static void AsyncReturningValueExample()
        {
            try
            {
                string data = await GetDummyData();
                Console.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
          
        }

        private static Task DoSomethingFaulty()
        {
            Task.Delay(2000);
            throw new Exception("This is custom exception.");
        }

        private static Task<string> GetDummyData()
        {
            Task.Delay(2000);
            throw new Exception("This is custom exception.");
        }

    }
}
