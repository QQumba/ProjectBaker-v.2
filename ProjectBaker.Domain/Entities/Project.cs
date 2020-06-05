using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBaker.Domain.Entities
{
	public class Project
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public string ProjectPhoto { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Project owner
        /// </summary>
        public string UserEmail { get; set; }
        public string PostDate { get; set; }
        public int FundGoal { get; set; }
        public int RatingPoints { get; set; }

        public virtual User User { get; set; }
        public virtual ProjectAccount ProjectAccount { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
