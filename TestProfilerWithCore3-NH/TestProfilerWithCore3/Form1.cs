using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using NHibernate;
using NHibernate.Cfg;
using TestProfilerWithCore3.ModelNH;

namespace TestProfilerWithCore3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActiveControl = NHbuttonAdd;
        }

        private void buttonSQLConnect_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=HibernatingRhinos.Profiler.IntegrationTests;Integrated Security=True";
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
                    MessageBox.Show("Cannot open connection!");
                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
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
            // Any Raw Query
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
    }
}
