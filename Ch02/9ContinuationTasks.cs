using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    class _9ContinuationTasks
    {
        public static void Main()
        {
            
            SimpleChain();
            Console.ReadLine();
            //PartialResponsive();
        }

        private async static void PartialResponsive()
        {
            var data = await FetchDataAsync();
        }

        private static void SimpleChain()
        {
            var task = Task.Factory.StartNew<DataTable>(() => 
            {
                Console.WriteLine("Fetching Data");
                return FetchData();
                }).ContinueWith(
                (e) => {
                    var firstRow = e.Result.Rows[0];
                    Console.WriteLine("Id is {0} and Name is {0}", firstRow["Id"], firstRow["Name"]);
                    });
           
        }

        static async Task<DataTable> FetchDataAsync()
        {
            //Simulate long running task
            //.......
            //Some dummy data
            return await Task.FromResult( new DataTable());
        }
        static DataTable FetchData()
        {
            //Simulate long running task
           //.....
            //Some dummy data
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Rows.Add(new object[] {"1", "Shakti"});
            return dataTable;
        }

        static void Display(DataTable data)
        {
            //Render UI
        }
    }
}
