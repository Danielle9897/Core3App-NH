//-----------------------------------------------------------------------
// <copyright file="ReadOnlyBlog.cs" company="Hibernating Rhinos LTD">
//     Copyright (c) Hibernating Rhinos LTD. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TestProfilerWithCore3.ModelNH
{
	public class ReadOnlyBlog
	{
		public virtual int Id { get; set; }
		public virtual string Title { get; set; }
	}
}