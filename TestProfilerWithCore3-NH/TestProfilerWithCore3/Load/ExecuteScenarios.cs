using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestProfilerWithCore3.ModelNH
{
    public static class ExecuteScenarios
    {
        public static async Task Go(List<Scenario> scenariosToExecute)
        {
            List<Task> itemsToRun = new List<Task>();
            
            // Build tasks array
            foreach (var item in scenariosToExecute)
            {
                for(int i = 0; i < item.ThreadsNumber; i++)
                {
                    int taskIndex = i;
                    //itemsToRun.Add(  Task.Run(async () => await item.Run(taskIndex)));
                    var task = Task.Factory.StartNew(async () => await item.Run(taskIndex), TaskCreationOptions.LongRunning); // todo: why do I still get only 0 & 1 for task number ?
                    itemsToRun.Add(task);
                    
//                    Parallel.ForEach(); // number of threads param // todo: try this ?
//                    Parallel.ForEach(null, new ParallelOptions()
//                    {
//                        MaxDegreeOfParallelism =
//                    })
                }
            }

            try
            {
                // Run all tasks and wait for them to finish
                await Task.WhenAll(itemsToRun.ToArray()); // todo: do they run in parallel ?
                Console.WriteLine("******* done *******");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}