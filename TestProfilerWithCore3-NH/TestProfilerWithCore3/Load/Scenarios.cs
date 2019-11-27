using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping;

namespace TestProfilerWithCore3.ModelNH
{
    public abstract class Scenario
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int ThreadsNumber { get; }
        public string Param { get; }
        
        public abstract Task Run(int taskNumber);
        
        public Scenario(int threads, string param)
        {
            ThreadsNumber = threads;
            Param = param;  
        }
        
        protected void Start(out Stopwatch sw ,int taskNumber) 
        {
            var timeNow = DateTime.Now;
            string startTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timeNow.Hour, timeNow.Minute, timeNow.Second, timeNow.Millisecond / 10);
            Console.WriteLine($"START => Scenario_{Id}: {Name} *** Task: {taskNumber} *** Start Time: {startTime}");
             
            sw = new Stopwatch();
            sw.Start();
        }

        protected void End(Stopwatch sw, int taskNumber)
        {
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string runTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"  END => Scenario_{Id}: {Name} *** Task: {taskNumber} *** Total Run Time: {runTime}");
        }
    }

    public class Scenario_0 : Scenario {

        public Scenario_0(int threads, string param) : base(threads, param) // todo : change 0 to name
        {
            Id = 0;
            Name = "Insert New Rows in Blog Table";
        }
        
        public override async Task Run(int taskNumber)
        {
            try
            {
                int.TryParse(Param, out var numberOfRowsToCreate); // todo: take value from UI. for now it is hardcoded.
                Start(out var stopwatch, taskNumber);
                
                var config = new Configuration();
                config.Configure();
                config.AddAssembly(typeof(Blog).Assembly);
                
                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();
                
                for (int i = 0; i < numberOfRowsToCreate; i++)
                {
                    await session.SaveAsync(new Blog() { // ok
                        Title = $"Inserted by Scenario_0, task: {taskNumber}",
                        CreatedAt = DateTime.Now, 
                        Subtitle = $"added row: {i}" 
                    });
                }
                
                await tx.CommitAsync();
                End(stopwatch, taskNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine("Scenario_0 " + e);
            }
        }
    }
    
    public class Scenario_1 : Scenario {

        public Scenario_1(int threads, string param) : base(threads, param)
        {
            Id = 1;
            Name = "Get All Rows from Blog Table";
        }
        
        public override Task Run(int taskNumber)
        {
            try
            {
                Start(out var stopwatch, taskNumber);
                var config = new Configuration();
                config.Configure();
                config.AddAssembly(typeof(Blog).Assembly);

                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();

                session.CreateCriteria<Blog>().List<Blog>();

                tx.Commit();
                End(stopwatch, taskNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine("Scenario_1 " + e);
            }
            return Task.CompletedTask;
        }
    }
    
    public class Scenario_2 : Scenario {

        public Scenario_2(int threads, string param) : base(threads, param)
        {
            Id = 2;
            Name = "Update All Rows in Blog Table";
        }
        
        public override Task Run(int taskNumber)
        {
            try
            {
                Start(out var stopwatch, taskNumber);
                var config = new Configuration();
                config.Configure();
                config.AddAssembly(typeof(Blog).Assembly);

                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();

                var blogs = session.CreateCriteria<Blog>().List<Blog>();
                foreach (var blog in blogs)
                {
                    blog.CreatedAt = DateTime.Now;
                    blog.Subtitle = "row was updated by Scenario_2";
                    session.Update(blog);
                }

                tx.Commit();
                End(stopwatch, taskNumber);
            }
           
            catch (Exception e)
            {
                Console.WriteLine("Scenario_2 " + e);
            }
            return Task.CompletedTask;
        }
    }
    
    public class Scenario_3 : Scenario {

        public Scenario_3(int threads, string param) : base(threads, param)
        {
            Id = 3;
            Name = "Query the Blog Table";
        }
        
        public override Task Run(int taskNumber)
        {
            try
            {
                Start(out var stopwatch, taskNumber);
                var config = new Configuration();
                config.Configure();
                config.AddAssembly(typeof(Blog).Assembly);

                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();

                //String hql = "FROM Blog b WHERE b.Id > 10 ORDER BY b.Subtitle DESC"; // this is not working
                String hql = "FROM Blog b WHERE b.Id > 10";
                IQuery query = session.CreateQuery(hql);
                IList<Blog> results = query.List<Blog>();

                tx.Commit();
                End(stopwatch, taskNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine("Scenario_3 " + e);
            }
            return Task.CompletedTask;
        }
    }
}