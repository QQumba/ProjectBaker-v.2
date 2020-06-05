using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading;

namespace ProjectBaker.Domain.Entities
{
	public class User
    { 
		public string Email { get; set; }
		public string Password { get; set; }
        public string ProfilePhoto { get; set; } //null
        //public string ExternalLogin { get; set; }
        public bool HasEmailConfirmed { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } //null
        public uint Age { get; set; }
        public string Country { get; set; }

        public virtual List<Role> Roles { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Project> Projects { get; set; }

        public bool IsValid()
        {
            if (Email == null || Password == null || FirstName == null || Country == null)
            {
                return false;
            }
            else
            {
                var commonRegex = new Regex(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$");
                var passwordRegex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$");
                
                if (LastName == null)
                {
                    var email = new EmailAddressAttribute().IsValid(Email);
                    var password = passwordRegex.IsMatch(Password);
                    var fname = commonRegex.IsMatch(FirstName);
                    var country = commonRegex.IsMatch(Country);

                    return (email && password && fname && country);
                }
                else
                {
                    var email = new EmailAddressAttribute().IsValid(Email);
                    var password = passwordRegex.IsMatch(Password);
                    var fname = commonRegex.IsMatch(FirstName);
                    var lname = commonRegex.IsMatch(LastName);
                    var country = commonRegex.IsMatch(Country);

                    return (email && password && fname && lname && country);
                }
            }
        }
    }
}
