using ProjectBaker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBaker.Domain.Repositories
{
	public interface IUserRepository
	{
		void AddUser(User user);
		Task AddUserAsync(User user);
		User GetUserByEmail(string email);
		Task<User> GetUserByEmailAsync(string email);
		User ValidateUser(User user);
		Task<User> ValidateUserAsync(User user);
		List<User> GetAllUsers();
	}
}
