using System;
using System.Collections.Generic;

namespace TestProfilerWithCore3.ModelSO
{
	public class PostSO
	{

		public virtual int Id { get; set; }
		public virtual int AcceptedAnswerId { get; set; }
		public virtual int AnswerCount { get; set; }
		public virtual string Body { get; set; }
		public virtual DateTime ClosedDate { get; set; }
		public virtual int CommentCount { get; set; }
		public virtual DateTime CommunityOwnedDate { get; set; }
		public virtual DateTime CreationDate { get; set; }
		public virtual int FavoriteCount { get; set; }
		public virtual DateTime LastActivityDate { get; set; }
		public virtual DateTime LastEditDate { get; set; }
		public virtual string LastEditorDisplayName { get; set; }
		public virtual int LastEditorUserId { get; set; }
		public virtual int OwnerUserId { get; set; }
		public virtual int ParentId { get; set; }
		public virtual int PostTypeId { get; set; }
		public virtual int Score { get; set; }
		public virtual string Tags { get; set; }
		public virtual string Title { get; set; }
		public virtual int ViewCount { get; set; }
	}
}