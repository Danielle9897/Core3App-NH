using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;
using TestProfilerWithCore3.ModelNH;
using TestProfilerWithCore3.Load;
using Environment = System.Environment;

namespace TestProfilerWithCore3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Text = "Core3 App for testing NHProf";
            
            HelpTextLabel.Text = "1. Select scenarios (click checboxes)" + Environment.NewLine +
                                 "2. Enter no. of threads to execute scenario (default is 1)" + Environment.NewLine + 
                                 "3. Enter Param where relevant" + Environment.NewLine +
                                 "4. Click Go";
            
            checkBoxNH_0.Text = Scenario_0_InsertNewRowsToBlogsTable.Name;
            checkBoxNH_1.Text = Scenario_1_GetAllRowsFromBlogsTable.Name;
            checkBoxNH_2.Text = Scenario_2_UpdateAllRowsInBlogsTable.Name;
            checkBoxNH_3.Text = Scenario_3_QueryBlogsTableById.Name;
            checkBoxSO_0.Text = Scenario_0_SO_InsertNewRowsToUsersTable.Name;
            checkBoxSO_1.Text = Scenario_1_SO_GetTopRowsFromUsersTableWithCondition.Name;
            checkBoxSO_2.Text = Scenario_2_SO_UpdateRowsInUsersTableWithCondition.Name;
            checkBoxSO_3.Text = Scenario_3_SO_DeleteFromCommentsTableWithCondition.Name;
            checkBoxSO_4.Text = Scenario_4_SO_TimeConsumingActionOnPostsTable.Name;
            checkBoxSO_5.Text = Scenario_5_SO_TimeConsumingActionOnPostsTable.Name;
            checkBoxSO_6.Text = Scenario_6_SO_TimeConsumingActionOnVotesTable.Name;
            labelNH_0.Text = Scenario_0_InsertNewRowsToBlogsTable.ParamText;
            labelNH_1.Text = Scenario_1_GetAllRowsFromBlogsTable.ParamText;
            labelNH_2.Text = Scenario_2_UpdateAllRowsInBlogsTable.ParamText;
            labelNH_3.Text = Scenario_3_QueryBlogsTableById.ParamText;
            labelSO_0.Text = Scenario_0_SO_InsertNewRowsToUsersTable.ParamText;
            labelSO_1.Text = Scenario_1_SO_GetTopRowsFromUsersTableWithCondition.ParamText;
            labelSO_2.Text = Scenario_2_SO_UpdateRowsInUsersTableWithCondition.ParamText;
            labelSO_3.Text = Scenario_3_SO_DeleteFromCommentsTableWithCondition.ParamText;
            labelSO_4.Text = Scenario_4_SO_TimeConsumingActionOnPostsTable.ParamText;
            labelSO_5.Text = Scenario_5_SO_TimeConsumingActionOnPostsTable.ParamText;
            labelSO_6.Text = Scenario_6_SO_TimeConsumingActionOnVotesTable.ParamText;
            
            ActiveControl = NHbuttonAdd;
        }

        private void buttonSQLConnect_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionStr = ExecuteScenarios.ConnectionStringToTestsDatabase;
                SqlConnection connection = new SqlConnection(connectionStr);
                String query = "select * from Blogs";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader dataReader;

                try
                {
                    connection.Open();
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"{dataReader.GetValue(0)} - {dataReader.GetValue(1)} - {dataReader.GetValue(2)}");
                    }
                    dataReader.Close();
                    command.Dispose();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection!" + ex.Message);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NHbuttonAdd_Click(object sender, EventArgs e)
        {
            // Add new Blog entry to Blogs table
            try
            {
                var config = new Configuration();
                config.Configure();
                config.AddAssembly(typeof(Blog).Assembly);
                using var factory = config.BuildSessionFactory(); 
                using var session = factory.OpenSession();
                using var transaction = session.BeginTransaction();
               
                var newBlog = new Blog() {
                     Title = "from NH",
                     CreatedAt = DateTime.Now
                };
                
                session.Save(newBlog);
                transaction.Commit();
                var lastBlogId = newBlog.Id;
                Console.WriteLine($"Added Blog: Blog with id {lastBlogId} was added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void NHbuttonGetAllBlogs_Click(object sender, EventArgs e)
        {
            // Get all blogs from Blogs table
            try
            {
                var config = new Configuration();
                config.Configure();
                config.AddAssembly(typeof(Blog).Assembly);
                using var factory = config.BuildSessionFactory();
                using var session = factory.OpenSession();
                using var transaction = session.BeginTransaction();
              
                var blogs = session.CreateCriteria<Blog>().List<Blog>();
                foreach (var blog in blogs)
                {
                    Console.WriteLine($"Blog Entry: Blog Id={blog.Id} Title={blog.Title} Created At={blog.CreatedAt}");
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        private void NHbuttonGetById_Click(object sender, EventArgs e)
        {
            // Get blog from Blogs table by ID
            try
            {
                if (int.TryParse(TextBoxBlogId.Text, out int id))
                {
                    var config = new Configuration();
                    config.Configure();
                    config.AddAssembly(typeof(Blog).Assembly);
                    using var factory = config.BuildSessionFactory();
                    using var session = factory.OpenSession();
                    using var transaction = session.BeginTransaction();

                    var blog = session.Get<Blog>(id);
                    transaction.Commit();
                    Console.WriteLine($"Get Blog by ID: Blog Id={id} Title={blog.Title}, Created at={blog.CreatedAt}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void NHbuttonUpdate_Click(object sender, EventArgs e)
        {
            // Update blog entry to now
            try
            {
                if (int.TryParse(TextBoxBlogId.Text, out int id))
                {
                    var config = new Configuration();
                    config.Configure();
                    config.AddAssembly(typeof(Blog).Assembly);
                    using var factory = config.BuildSessionFactory();
                    using var session = factory.OpenSession();
                    using var transaction = session.BeginTransaction();

                    var blog = session.Get<Blog>(id);
                    blog.CreatedAt = DateTime.Now;
                    session.Update(blog);
                    transaction.Commit();
                    Console.WriteLine($"Updated 'Created At' for blog {id} to now");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void NHbuttonDelete_Click(object sender, EventArgs e)
        {
            // Delete a blog entry
            try
            {
                if (int.TryParse(TextBoxBlogId.Text, out int id))
                {
                    var config = new Configuration();
                    config.Configure();
                    config.AddAssembly(typeof(Blog).Assembly);
                    using var factory = config.BuildSessionFactory();
                    using var session = factory.OpenSession();
                    using var transaction = session.BeginTransaction();

                    var blog = session.Get<Blog>(id);
                    session.Delete(blog);
                    transaction.Commit();
                    Console.WriteLine($"Deleted blog with id={id}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void NHGetBlogFromPost_Click(object sender, EventArgs e)
        {
            // Get blog from a post (related document)
            try
            {
                if (int.TryParse(TextBoxBlogId.Text, out int postId))
                {
                    var config = new Configuration();
                    config.Configure();
                    config.AddAssembly(typeof(Post).Assembly);
                    using var factory = config.BuildSessionFactory();
                    using var session = factory.OpenSession();
                    using var transaction = session.BeginTransaction();

                    var post = session.Get<Post>(postId);
                    var blog = post.Blog;
                    transaction.Commit();
                    Console.WriteLine($"Blog from Post: *** Blog Id={blog.Id} Title={blog.Title}, Created at={blog.CreatedAt}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void NHGetBlogsCount_Click(object sender, EventArgs e)
        {
            // Get blogs count using CreateQuery
            try
            {
                var config = new Configuration();
                config.Configure();
                config.AddAssembly(typeof(Post).Assembly);
                using var factory = config.BuildSessionFactory();
                using var session = factory.OpenSession();
                using var transaction = session.BeginTransaction();

                IQuery query = session.CreateQuery("FROM Blog");
                IList<Blog> blogs = query.List<Blog>();
                transaction.Commit();
                Console.WriteLine("blogs.Count = " + blogs.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void NHButtonRawQuery_Click(object sender, EventArgs e)
        {
            // Any HQL Query
            var queryFromUI = QueryTextBox.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(queryFromUI) == false)
                {
                    var config = new Configuration();
                    config.Configure();
                    config.AddAssembly(typeof(Post).Assembly);
                    using var factory = config.BuildSessionFactory();
                    using var session = factory.OpenSession();
                    using var transaction = session.BeginTransaction();

                    IQuery query = session.CreateQuery(queryFromUI);
                    query.List<Blog>();
                    transaction.Commit();
                    Console.WriteLine($"Executed query: {queryFromUI}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void asyncButton_Click(object sender, EventArgs e)
        {
            testAsync();
        }
        
        private async Task testAsync()
        {
            var config = new Configuration();
            config.Configure();
            config.AddAssembly(typeof(Post).Assembly);
            using var factory = config.BuildSessionFactory();
            using var session = factory.OpenSession();

            Blog newBlog = new Blog()
            {
                AllowsComments = true,
                CreatedAt = DateTime.Now,
                Subtitle = "test Async",
                Title = "The async blog"
            };
            
            // This code worked ok
            try
            {
                using (var transaction = session.BeginTransaction())
                {
                    await session.SaveOrUpdateAsync(newBlog);
                 
                    List<Blog> allBlogs = await session.Query<Blog>().ToListAsync();
                    Console.WriteLine($"Blogs count = {allBlogs.Count}");
                    
                    List<Blog> asyncBlogs = await session.Query<Blog>().Where(x => x.Title.Contains("async")).ToListAsync();
                    Console.WriteLine($"Async blog from query1: id={asyncBlogs[0].Id} title={asyncBlogs[0].Title}");
                    
                    Blog blog = await session.Query<Blog>().Where(x => x.Id == newBlog.Id).SingleOrDefaultAsync();
                    Console.WriteLine($"Async blog from query2: id={asyncBlogs[0].Id} title={asyncBlogs[0].Title}");
                    
                    blog = await session.LoadAsync<Blog>(newBlog.Id);
                    blog.Title = "new title";
                    await session.SaveAsync(blog);
                    
                    blog = await session.GetAsync<Blog>(newBlog.Id);
                    Console.WriteLine($"Async blog after modify: id={blog.Id} title={blog.Title}");
                    
                    await transaction.CommitAsync();
                }

                using (var transaction = session.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    await session.DeleteAsync(newBlog);
                    await transaction.CommitAsync();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private Thread bgThread;
        
        private void GoButton_Click(object sender, EventArgs e)
        {
            //bgThread = new Thread(new ThreadStart(DoWork));
            bgThread = new Thread(DoWork);
            bgThread.IsBackground = true;
            bgThread.Start();
        }
        
        private void DoWork() {
            // This is background processing. To update UI from another thread use Control.Invoke(...)
            
            var scenariosList = new List<Scenario>();
            
            if (checkBoxNH_0.Checked && GetParamValue(textBoxParamNH_0,Scenario_0_InsertNewRowsToBlogsTable.Name, out string param))
                scenariosList.Add(new Scenario_0_InsertNewRowsToBlogsTable(GetThreadsNumber(textBoxThreadsNH_0), param));
            
            if (checkBoxNH_1.Checked)
                scenariosList.Add(new Scenario_1_GetAllRowsFromBlogsTable(GetThreadsNumber(textBoxThreadsNH_1), ""));
            
            if (checkBoxNH_2.Checked && GetParamValue(textBoxParamNH_2,Scenario_2_UpdateAllRowsInBlogsTable.Name, out param))
                scenariosList.Add(new Scenario_2_UpdateAllRowsInBlogsTable(GetThreadsNumber(textBoxThreadsNH_2), param));
            
            if (checkBoxNH_3.Checked && GetParamValue(textBoxParamNH_3,Scenario_3_QueryBlogsTableById.Name, out param))
                scenariosList.Add(new Scenario_3_QueryBlogsTableById(GetThreadsNumber(textBoxThreadsNH_3), param));
            
            if (checkBoxSO_0.Checked && GetParamValue(textBoxParamSO_0,Scenario_0_SO_InsertNewRowsToUsersTable.Name, out param))
                scenariosList.Add(new Scenario_0_SO_InsertNewRowsToUsersTable(GetThreadsNumber(textBoxThreadsSO_0), param));
            
            if (checkBoxSO_1.Checked && GetParamValue(textBoxParamSO_1,Scenario_1_SO_GetTopRowsFromUsersTableWithCondition.Name, out param))
                scenariosList.Add(new Scenario_1_SO_GetTopRowsFromUsersTableWithCondition(GetThreadsNumber(textBoxThreadsSO_1), param));
            
            if (checkBoxSO_2.Checked && GetParamValue(textBoxParamSO_2,Scenario_2_SO_UpdateRowsInUsersTableWithCondition.Name, out param))
                scenariosList.Add(new Scenario_2_SO_UpdateRowsInUsersTableWithCondition(GetThreadsNumber(textBoxThreadsSO_2), param));
            
            if (checkBoxSO_3.Checked && GetParamValue(textBoxParamSO_3,Scenario_3_SO_DeleteFromCommentsTableWithCondition.Name, out param))
                scenariosList.Add(new Scenario_3_SO_DeleteFromCommentsTableWithCondition(GetThreadsNumber(textBoxThreadsSO_3), param));
            
            if (checkBoxSO_4.Checked)
                scenariosList.Add(new Scenario_4_SO_TimeConsumingActionOnPostsTable(GetThreadsNumber(textBoxThreadsSO_4), ""));
            
            if (checkBoxSO_5.Checked)
                scenariosList.Add(new Scenario_5_SO_TimeConsumingActionOnPostsTable(GetThreadsNumber(textBoxThreadsSO_5), ""));
            
            if (checkBoxSO_6.Checked)
                scenariosList.Add(new Scenario_6_SO_TimeConsumingActionOnVotesTable(GetThreadsNumber(textBoxThreadsSO_6), ""));

            if (scenariosList.Count == 0)
            {
                MessageBox.Show("No scenarios are scheduled to run", "", MessageBoxButtons.OK);
            }
            else
            {
                ExecuteScenarios.Go(scenariosList);
            }
        }

        private int GetThreadsNumber(TextBox threadTextBox)
        {
            var result = int.TryParse(threadTextBox.Text, out var threadsNumber);
            return (result == false || threadsNumber == 0) ? 1 : threadsNumber; 
        }

        private bool GetParamValue(TextBox paramTextBox, string name, out string param)
        {
            param = paramTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(param))
            {
                MessageBox.Show($"Scenario: *** {name} *** {Environment.NewLine}{Environment.NewLine}Missing param value", "Missing Param", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
    }
}
