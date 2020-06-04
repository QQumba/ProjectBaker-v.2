using Microsoft.EntityFrameworkCore;
using ProjectBaker.Domain.Entities;
using ProjectBaker.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBaker.DAL.Repositories
{
	public class UserRepository : IUserRepository
	{
		private AppDbContext _db;

		public UserRepository(AppDbContext context)
		{
			_db = context;
		}

		public void AddUser(User user)
		{
			_db.Users.Add(user);
			_db.SaveChanges();
		}
		
		public async Task AddUserAsync(User user)
		{
			await _db.Users.AddAsync(user);
			await _db.SaveChangesAsync();
		}

		public User GetUserByEmail(string email)
		{
			User user = null;
			user = _db.Users.FirstOrDefault(u => u.Email == email);
			return user;
		}

		public async Task<User> GetUserByEmailAsync(string email)
		{
			var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == email);
			return user;
		}

		public List<User> GetAllUsers()
		{
			List<User> users = null;
			users = _db.Users.Select(u => u).ToList();
			return users;
		}

		public User ValidateUser(User user)
		{
			User validatedUser = null;
			validatedUser = _db.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
			return validatedUser;
		}

		public async Task<User> ValidateUserAsync(User user)
		{
			User validatedUser = null;
			validatedUser = await _db.Users.FirstOrDefaultAsync(u => u.Email == user.Email && u.Password == user.Password);
			return validatedUser;
		}

		
	}
}
