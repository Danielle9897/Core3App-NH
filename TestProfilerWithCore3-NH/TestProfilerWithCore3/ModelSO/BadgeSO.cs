using System;

namespace TestProfilerWithCore3.ModelSO
{
	public class BadgeSO
	{
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual int UserId { get; set; }
		public virtual DateTime Date { get; set; }
	}
}