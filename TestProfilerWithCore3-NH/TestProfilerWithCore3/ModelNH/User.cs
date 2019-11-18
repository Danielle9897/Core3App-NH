//-----------------------------------------------------------------------
// <copyright file="User.cs" company="Hibernating Rhinos LTD">
//     Copyright (c) Hibernating Rhinos LTD. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace TestProfilerWithCore3.ModelNH
{
	public class User
	{
		public User()
		{
			Blogs = new HashSet<Blog>();
			Posts = new HashSet<Post>();
		}

		public virtual int Id { get; set; }
		public virtual byte[] Password { get; set; }
		public virtual string Email { get; set; }
		public virtual string Username { get; set; }
		public virtual DateTime CreatedAt { get; set; }
		public virtual string Bio { get; set; }

		public virtual ISet<Blog> Blogs { get; set; }
		public virtual ISet<Post> Posts { get; set; }
	}
}