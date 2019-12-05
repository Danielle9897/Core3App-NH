using System;

namespace TestProfilerWithCore3.ModelSO
{
	public class UserSO
	{
		public virtual int Id { get; set; }
		public virtual string AboutMe { get; set; }
		public virtual int Age { get; set; }
		public virtual DateTime CreationDate { get; set; }
		public virtual string DisplayName { get; set; }
		public virtual int DownVotes { get; set; }
		public virtual string EmailHash { get; set; }
		public virtual DateTime LastAccessDate { get; set; }
		public virtual string Location { get; set; }
		public virtual int Reputation { get; set; }
		public virtual int UpVotes { get; set; }
		public virtual int Views { get; set; }
		public virtual string WebsiteUrl { get; set; }
		public virtual int AccountId { get; set; }
	}
}