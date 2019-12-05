using System;
using System.Diagnostics;
using System.Threading.Tasks;
using NHibernate.Cfg;

namespace TestProfilerWithCore3.Load
{
    public abstract class Scenario
    {
        public int ThreadsNumber { get; }
        protected string Param { get; }
        
        public abstract Task Run(int taskIndex);
        
        protected Scenario(int threads, string param)
        {
            ThreadsNumber = threads;
            Param = param;  
        }
        
        protected void Start(out Stopwatch sw ,string scenarioId, string ScenarioName, int taskIndex) 
        {
            var timeNow = DateTime.Now;
            string startTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timeNow.Hour, timeNow.Minute, timeNow.Second, timeNow.Millisecond / 10);
            Console.WriteLine($"START => Scenario_{scenarioId}: {ScenarioName} *** Task: {scenarioId}-{taskIndex} *** Start Time: {startTime}");
             
            sw = new Stopwatch();
            sw.Start();
        }

        protected void End(Stopwatch sw, string scenarioId, string ScenarioName, int taskIndex) 
        {
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string runTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"  END => Scenario_{scenarioId}: {ScenarioName} *** Task: {scenarioId}-{taskIndex} *** Total Run Time: {runTime}");
        }
        
        protected Configuration initConfiguration<T>(string conStr)
        {
            var config = new Configuration();
            config.Configure();
            config.AddAssembly(typeof(T).Assembly);
            config.Properties["connection.connection_string"] = conStr;
            return config;
        } 
    }
}