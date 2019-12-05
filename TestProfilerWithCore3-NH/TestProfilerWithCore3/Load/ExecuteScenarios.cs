using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestProfilerWithCore3.Load
{
    public static class ExecuteScenarios
    {
        public static string ConnectionStringToTestsDatabase = "Data Source=.\\sqlexpress;Initial Catalog=HibernatingRhinos.Profiler.IntegrationTests;Integrated Security=True";
        public static string ConnectionStringToSODatabase = "Data Source=.\\sqlexpress;Initial Catalog=StackOverflow2010;Integrated Security=True";
        
        public static async Task Go(List<Scenario> scenariosToExecute)
        {
            List<Task> itemsToRun = new List<Task>();

            try
            {
                // Build tasks array & run
                foreach (var item in scenariosToExecute)
                {
                    for(int i = 0; i < item.ThreadsNumber; i++)
                    {
                        int taskIndex = i;
                        //itemsToRun.Add(Task.Run(async () => await item.Run(taskIndex)));
                        var task = Task.Factory.StartNew(async () => await item.Run(taskIndex), TaskCreationOptions.LongRunning);
                        itemsToRun.Add(task);
                    }
                }
                
                await Task.WhenAll(itemsToRun.ToArray());
                Console.WriteLine("******* done *******"); // todo : why is this sometimes printed before all are done ?
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}