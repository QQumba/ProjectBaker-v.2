using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBaker.Domain.Entities
{
	public class User
	{
		public string Email { get; set; }
		public string Password { get; set; }
        public string ProfilePhoto { get; set; }
        //public string ExternalLogin { get; set; }
        public bool HasEmailConfirmed { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Age { get; set; }
        public string Country { get; set; }

        public virtual List<Role> Roles { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Project> Projects { get; set; }

    }
}
