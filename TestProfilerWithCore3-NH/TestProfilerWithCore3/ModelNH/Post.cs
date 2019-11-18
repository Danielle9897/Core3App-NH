//-----------------------------------------------------------------------
// <copyright file="Post.cs" company="Hibernating Rhinos LTD">
//     Copyright (c) Hibernating Rhinos LTD. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace TestProfilerWithCore3.ModelNH
{
	public class Post
	{
		public Post()
		{
			Tags = new HashSet<Tag>();
			Categories = new HashSet<Category>();
			Comments = new HashSet<Comment>();
		}

		public virtual int Id { get; set; }
		public virtual Blog Blog { get; set; }
		public virtual User User { get; set; }
		public virtual string Title { get; set; }
		public virtual string Text { get; set; }
		public virtual DateTime PostedAt { get; set; }

		public virtual ISet<Comment> Comments { get; set; }
		public virtual ISet<Category> Categories { get; set; }
		public virtual ISet<Tag> Tags { get; set; }
	}
}