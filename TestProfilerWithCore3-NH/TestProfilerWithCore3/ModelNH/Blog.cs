//-----------------------------------------------------------------------
// <copyright file="Blog.cs" company="Hibernating Rhinos LTD">
//     Copyright (c) Hibernating Rhinos LTD. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace TestProfilerWithCore3.ModelNH
{
	public class Blog
	{
		public Blog()
		{
			Posts = new HashSet<Post>();
			Users = new HashSet<User>();
			Tags = new HashSet<Tag>();
		}

		public virtual int Id { get; set; }

		public virtual string Title { get; set; }

		public virtual string Subtitle { get; set; }
		public virtual bool AllowsComments { get; set; }
		public virtual DateTime CreatedAt { get; set; }

		public virtual ISet<Post> Posts { get; set; }
		public virtual ISet<User> Users { get; set; }
		public virtual ISet<Tag> Tags { get; set; }
	}
}