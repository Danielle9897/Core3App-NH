using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using TestProfilerWithCore3.ModelNH;

namespace TestProfilerWithCore3.Load
{
    public class Scenario_0_InsertNewRowsToBlogsTable : Scenario
    {
        public static string Id = "0";
        public static string Name = "Insert new rows to 'Blogs'";
        public static string ParamText = "(Number of rows to insert)";
        
        public Scenario_0_InsertNewRowsToBlogsTable(int threads, string numberOfNewRowsToInsert) : base(threads, numberOfNewRowsToInsert) {}
        
        public override async Task Run(int taskIndex)
        {
            try
            {
                var result = int.TryParse(Param, out var numberOfRowsToInsert);
                if (result == false)
                {
                    MessageBox.Show($"Scenario: *** {Name} *** {Environment.NewLine}{Environment.NewLine} Invalid number of rows param","Invalid Param", MessageBoxButtons.OK);
                    return;
                }
                
                Start(out var stopwatch, Id, Name, taskIndex);
                var config = initConfiguration<Blog>(ExecuteScenarios.ConnectionStringToTestsDatabase);
                
                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();
                
                for (int i = 0; i < numberOfRowsToInsert; i++)
                {
                    await session.SaveAsync(new Blog() {
                        Title = $"Inserted by Scenario_0, task: {Id}-{taskIndex}",
                        CreatedAt = DateTime.Now, 
                        Subtitle = $"added row: {i}" 
                    });
                }
                
                await tx.CommitAsync();
                End(stopwatch, Id, Name, taskIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine("Scenario_0 " + e);
            }
        }
    }
    
    public class Scenario_1_GetAllRowsFromBlogsTable : Scenario {

        public static string Id = "1";
        public static string Name = "Get all rows from 'Blogs'";
        public static string ParamText = "";
        
        public Scenario_1_GetAllRowsFromBlogsTable(int threads, string param) : base(threads, param) {}
        
        public override Task Run(int taskIndex)
        {
            try
            {
                Start(out var stopwatch, Id, Name, taskIndex);
                var config = initConfiguration<Blog>(ExecuteScenarios.ConnectionStringToTestsDatabase);

                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();

                session.CreateCriteria<Blog>().List<Blog>();

                tx.Commit();
                End(stopwatch, Id, Name, taskIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine("Scenario_1 " + e);
            }
            return Task.CompletedTask;
        }
    }
    
    public class Scenario_2_UpdateAllRowsInBlogsTable : Scenario {

        public static string Id = "2";
        public static string Name = "Update all rows in 'Blogs'";
        public static string ParamText = "(New SubTitle text)";
        
        public Scenario_2_UpdateAllRowsInBlogsTable(int threads, string newSubTitle) : base(threads, newSubTitle) {}
        
        public override Task Run(int taskIndex)
        {
            try
            {
                Start(out var stopwatch, Id, Name, taskIndex);
                var config = initConfiguration<Blog>(ExecuteScenarios.ConnectionStringToTestsDatabase);

                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();

                var blogs = session.CreateCriteria<Blog>().List<Blog>();
                foreach (var blog in blogs)
                {
                    blog.CreatedAt = DateTime.Now;
                    blog.Title = "Modified";
                    blog.Subtitle = Param; //"Row was updated by Scenario_2";
                    session.Update(blog);
                }

                tx.Commit();
                End(stopwatch, Id, Name, taskIndex);
            }
           
            catch (Exception e)
            {
                Console.WriteLine("Scenario_2 " + e);
            }
            return Task.CompletedTask;
        }
    }
    
    public class Scenario_3_QueryBlogsTableById : Scenario {

        public static string Id = "3";
        public static string Name = "Get all blogs above Id";
        public static string ParamText = "(Min Id)";
        
        public Scenario_3_QueryBlogsTableById(int threads, string minId) : base(threads, minId) {}
        
        public override Task Run(int taskIndex)
        {
            try
            {
                Start(out var stopwatch, Id, Name, taskIndex);
                var config = initConfiguration<Blog>(ExecuteScenarios.ConnectionStringToTestsDatabase);

                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();

                //String hql = "FROM Blog b WHERE b.Id > 10 ORDER BY b.Subtitle DESC"; // this is not working with the ORDER BY - why ?
                var minId = Param.Trim();
                String hql = $"FROM Blog b WHERE b.Id > {minId}";
                IQuery query = session.CreateQuery(hql);
                IList<Blog> results = query.List<Blog>();

                tx.Commit();
                End(stopwatch, Id, Name, taskIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine("Scenario_3 " + e);
            }
            return Task.CompletedTask;
        }
    }
}