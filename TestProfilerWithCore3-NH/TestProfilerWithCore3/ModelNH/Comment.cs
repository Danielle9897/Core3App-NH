//-----------------------------------------------------------------------
// <copyright file="Comment.cs" company="Hibernating Rhinos LTD">
//     Copyright (c) Hibernating Rhinos LTD. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TestProfilerWithCore3.ModelNH
{
	public class Comment
	{
		public virtual int Id { get; set; }
		public virtual Post Post { get; set; }
		public virtual string Name { get; set; }
		public virtual string Email { get; set; }
		public virtual string HomePage { get; set; }
		public virtual int Ip { get; set; }
		public virtual string Text { get; set; }
	}
}