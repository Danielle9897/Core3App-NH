using System;

namespace TestProfilerWithCore3.ModelSO
{
	public class PostLinkSO
	{
		public virtual int Id { get; set; }
		public virtual DateTime CreationDate { get; set; }
		public virtual int PostId { get; set; }
		public virtual int RelatedPostId { get; set; }
		public virtual int LinkTypeId { get; set; }
	}
}