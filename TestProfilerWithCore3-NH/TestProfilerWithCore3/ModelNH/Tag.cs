//-----------------------------------------------------------------------
// <copyright file="Tag.cs" company="Hibernating Rhinos LTD">
//     Copyright (c) Hibernating Rhinos LTD. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TestProfilerWithCore3.ModelNH
{
	public class Tag
	{
		public virtual int Id { get; set; }
		public virtual object Entity { get; set; }
		public virtual string Name { get; set; }
	}
}