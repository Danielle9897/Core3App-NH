using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProfilerWithCore3.ModelSO;

namespace TestProfilerWithCore3.Load
{
    public class Scenario_0_SO_InsertNewRowsToUsersTable : Scenario {
        
        public static string Id = "0_SO";
        public static string Name = "Insert new rows to 'Users'";
        public static string ParamText = "(Number of rows to insert)";
        
        public Scenario_0_SO_InsertNewRowsToUsersTable(int threads, string numberOfRowsToInsert) : base(threads, numberOfRowsToInsert) {}
      
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
                var config = initConfiguration<UserSO>(ExecuteScenarios.ConnectionStringToSODatabase);
                
                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();
                
                for (int i = 0; i < numberOfRowsToInsert; i++)
                {
                    await session.SaveAsync(new UserSO() {
                        AboutMe = $"Inserted by Scenario_0_SO, task: {Id}-{taskIndex}",
                        CreationDate = DateTime.Now,
                        LastAccessDate = DateTime.Now,
                        DisplayName = "New Record"
                    });
                }
                
                await tx.CommitAsync();
                End(stopwatch, Id, Name, taskIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine("Scenario_0_SO " + e);
            }
        }
    }
    
    public class Scenario_1_SO_GetTopRowsFromUsersTableWithCondition : Scenario {

        public static string Id = "1_SO";
        public static string Name = "Get top rows from 'Users' (with Where)";
        public static string ParamText = "(Number of rows to get)";
        
        public Scenario_1_SO_GetTopRowsFromUsersTableWithCondition(int threads, string numberOTopRowsToGet) : base(threads, numberOTopRowsToGet) {}
        
        public override Task Run(int taskIndex)
        {
            try
            {
                var result = int.TryParse(Param, out var numberOfRowsToGet);
                if (result == false)
                {
                    MessageBox.Show($"Scenario: *** {Name} *** {Environment.NewLine}{Environment.NewLine} Invalid number of rows param","Invalid Param", MessageBoxButtons.OK);
                    return Task.CompletedTask;;
                }
                
                Start(out var stopwatch, Id, Name, taskIndex);
                var config = initConfiguration<UserSO>(ExecuteScenarios.ConnectionStringToSODatabase);

                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();
                
                var topUsers =
                    (
                        from user in session.Query<UserSO>()
                        where user.DisplayName.StartsWith("a") &&
                              user.Reputation > 15 * 1000
                        select user
                    )
                    .Take(numberOfRowsToGet)
                    .OrderBy(x => x.Id);
                
                var users = topUsers.ToList();
                
                tx.Commit();
                End(stopwatch, Id, Name, taskIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine("Scenario_1_SO " + e);
            }
            return Task.CompletedTask;
        }
    }
    
    public class Scenario_2_SO_UpdateRowsInUsersTableWithCondition : Scenario {

        public static string Id = "2_SO";
        public static string Name = "Update rows in 'Users' that contain text"; // i.e. where 'Location' contains 'CA'
        public static string ParamText = "(Text within 'Location' column)";
        
        public Scenario_2_SO_UpdateRowsInUsersTableWithCondition(int threads, string stringInLocation) : base(threads, stringInLocation) {}
        
        public override Task Run(int taskIndex)
        {
            try
            {
                Start(out var stopwatch, Id, Name, taskIndex);
                var config = initConfiguration<CommentSO>(ExecuteScenarios.ConnectionStringToSODatabase);

                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();

                var users = session.CreateQuery($"update UserSO set AboutMe = 'Modified by Scenario_2_SO' where Location like '%{Param.Trim()}%'")
                    .ExecuteUpdate();

                tx.Commit();
                End(stopwatch, Id, Name, taskIndex);
            }
           
            catch (Exception e)
            {
                Console.WriteLine("Scenario_2_SO " + e);
            }
            return Task.CompletedTask;
        }
    }
    
    public class Scenario_3_SO_DeleteFromCommentsTableWithCondition : Scenario {

        public static string Id = "3_SO";
        public static string Name = "Delete from 'Comments' above Score"; // where Score > X
        public static string ParamText = "(Min Score)";
        
        public Scenario_3_SO_DeleteFromCommentsTableWithCondition(int threads, string minScore) : base(threads, minScore) {}
        
        public override Task Run(int taskIndex)
        {
            try
            {
                var result = int.TryParse(Param, out var minScore);
                if (result == false)
                {
                    MessageBox.Show($"Scenario {Name}: Please enter min score");
                    return Task.CompletedTask;;
                }
                
                Start(out var stopwatch, Id, Name, taskIndex);
                var config = initConfiguration<CommentSO>(ExecuteScenarios.ConnectionStringToSODatabase);

                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();

                session.Delete($"from CommentSO c where c.Score > {minScore}"); 

                tx.Commit();
                End(stopwatch, Id, Name, taskIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine("Scenario_3_SO " + e);
            }
            return Task.CompletedTask;
        }
    }
    
    public class Scenario_4_SO_TimeConsumingActionOnPostsTable : Scenario {

        public static string Id = "4_SO";
        public static string Name = "Time consuming query on 'Posts' 1";
        public static string ParamText = "";
        
        public Scenario_4_SO_TimeConsumingActionOnPostsTable(int threads, string param) : base(threads, param) {}
        
        public override Task Run(int taskIndex)
        {
            try
            {
                Start(out var stopwatch, Id, Name, taskIndex);
                var config = initConfiguration<PostSO>(ExecuteScenarios.ConnectionStringToSODatabase);

                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();
                
                // Both options below take forever....
                
                // Select all:
                //session.CreateCriteria<PostSO>().List<PostSO>();
                
                // Select all with projections:
                var results = session.QueryOver<PostSO>()
                                     .Select(p => p.Id, p => p.Title, p => p.Body, p => p.Score, p => p.Tags, p => p.AnswerCount)
                                     .List();

                tx.Commit();
                End(stopwatch, Id, Name, taskIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine("Scenario_4_SO " + e);
            }
            return Task.CompletedTask;
        }
    }
    
    public class Scenario_5_SO_TimeConsumingActionOnPostsTable : Scenario {

        public static string Id = "5_SO";
        public static string Name = "Time consuming query on 'Posts' 2"; 
        public static string ParamText = "";
        
        public Scenario_5_SO_TimeConsumingActionOnPostsTable(int threads, string param) : base(threads, param) {}
        
        public override Task Run(int taskIndex)
        {
            try
            {
                Start(out var stopwatch, Id, Name, taskIndex);
                var config = initConfiguration<PostSO>(ExecuteScenarios.ConnectionStringToSODatabase);

                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();

                // This took about 3 minutes from MS Sql Management Studio
                // But when run from here you get:  "The timeout period elapsed prior to completion of the operation or the server is not responding."
                var posts = session.CreateQuery($"update PostSO set Body = 'Modified by Scenario_5_SO' where AnswerCount = 0").ExecuteUpdate();
                
                //tx.Rollback(); ???
                tx.Commit();
                End(stopwatch, Id, Name, taskIndex);
            }
           
            catch (Exception e)
            {
                Console.WriteLine("Scenario_5_SO " + e);
            }
            return Task.CompletedTask;
        }
    }
    
    public class Scenario_6_SO_TimeConsumingActionOnVotesTable : Scenario {

        public static string Id = "6_SO";
        public static string Name = "Time consuming query on 'Votes'"; 
        public static string ParamText = "";
        
        public Scenario_6_SO_TimeConsumingActionOnVotesTable(int threads, string param) : base(threads, param) {}
        
        public override Task Run(int taskIndex)
        {
            try
            {
                Start(out var stopwatch, Id, Name, taskIndex);
                var config = initConfiguration<VoteSO>(ExecuteScenarios.ConnectionStringToSODatabase);

                using var session = config.BuildSessionFactory().OpenSession();
                using var tx = session.BeginTransaction();
                
                // This takes forever....
                
                // Select all:
                session.CreateCriteria<VoteSO>().List<VoteSO>();
                
                // update, flush and rollback...?
              
                tx.Commit();
                End(stopwatch, Id, Name, taskIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine("Scenario_6_SO " + e);
            }
            return Task.CompletedTask;
        }
    }
}