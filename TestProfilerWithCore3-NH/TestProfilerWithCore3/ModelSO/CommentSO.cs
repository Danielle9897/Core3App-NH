using System;

namespace TestProfilerWithCore3.ModelSO
{
	public class CommentSO
	{
		public virtual int Id { get; set; }
		public virtual DateTime CreationDate { get; set; }
		public virtual int PostId { get; set; }
		public virtual int Score { get; set; }
		public virtual string Text { get; set; }
		public virtual int UserId { get; set; }
	}
}