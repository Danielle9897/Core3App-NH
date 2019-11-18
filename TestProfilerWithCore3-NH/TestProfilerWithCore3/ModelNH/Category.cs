//-----------------------------------------------------------------------
// <copyright file="Category.cs" company="Hibernating Rhinos LTD">
//     Copyright (c) Hibernating Rhinos LTD. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System.Collections.Generic;

namespace TestProfilerWithCore3.ModelNH
{
	public class Category
	{
		public Category()
		{
			Posts = new HashSet<Post>();
		}

		public virtual int Id { get; set; }
		public virtual string Name { get; set; }

		public virtual ISet<Post> Posts { get; set; }
	}
}