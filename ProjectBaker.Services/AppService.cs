using ProjectBaker.Domain.Entities;
using ProjectBaker.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectBaker.Services
{
	public class AppService : IAppService, IUserRepository
	{
		private IProjectRepository _projectRepository;
		private IUserRepository _userRepository;

		public AppService(IProjectRepository projectRepository, IUserRepository userRepository)
		{
			_projectRepository = projectRepository;
			_userRepository = userRepository;
		}

		public void AddProject(Project project)
		{
			_projectRepository.AddProject(project);
		}

		public void AddUser(User user)
		{
			_userRepository.AddUser(user);
		}

		public Task AddUserAsync(User user)
		{
			return _userRepository.AddUserAsync(user);
		}

		public List<Project> GetAllProjects()
		{
			return _projectRepository.GetAllProjects();
		}

		public List<User> GetAllUsers()
		{
			return _userRepository.GetAllUsers();
		}

		public Project GetProjectById(int id)
		{
			return _projectRepository.GetProjectById(id);
		}

		public User GetUserByEmail(string email)
		{
			return _userRepository.GetUserByEmail(email);
		}

		public Task<User> GetUserByEmailAsync(string email)
		{
			return _userRepository.GetUserByEmailAsync(email);
		}

		public User ValidateUser(User user)
		{
			return _userRepository.ValidateUser(user);
		}

		public Task<User> ValidateUserAsync(User user)
		{
			return _userRepository.ValidateUserAsync(user);
		}
	}
}
