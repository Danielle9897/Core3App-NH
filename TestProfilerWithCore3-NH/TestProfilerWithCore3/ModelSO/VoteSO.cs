using System;

namespace TestProfilerWithCore3.ModelSO
{
	public class VoteSO
	{
		public virtual int Id { get; set; }
		public virtual int PostId { get; set; }
		public virtual int UserId { get; set; }
		public virtual int BountyAmount { get; set; }
		public virtual int VoteTypeId { get; set; }
		public virtual DateTime CreationDate { get; set; }
	}
}