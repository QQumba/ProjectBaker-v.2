using ProjectBaker.Domain.Entities;
using ProjectBaker.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectBaker.Services
{
	public class AppService 
		: IProjectRepository
		, IUserRepository
		, IJobRepository
		, ICommentRepository
		, IReviewRepository
		, IRoleRepository
	{
		private IProjectRepository _projectRepository;
		private IUserRepository _userRepository;
		private IJobRepository _jobRepository;
		private ICommentRepository _commentRepository;
		private IReviewRepository _reviewRepository;
		private IRoleRepository _roleRepository;


		public AppService(
			IProjectRepository projectRepository,
			IUserRepository userRepository,
			IJobRepository jobRepository,
			ICommentRepository commentRepository,
			IReviewRepository reviewRepository,
			IRoleRepository roleRepository)
		{
			_projectRepository = projectRepository;
			_userRepository = userRepository;
			_jobRepository = jobRepository;
			_commentRepository = commentRepository;
			_reviewRepository = reviewRepository;
			_roleRepository = roleRepository;
		}

		public void AddComment(Comment comment)
		{
			_commentRepository.AddComment(comment);
		}

		public void AddJob(Job user)
		{
			_jobRepository.AddJob(user);
		}

		public void AddProject(Project project)
		{
			_projectRepository.AddProject(project);
		}

		public void AddReview(Review user)
		{
			_reviewRepository.AddReview(user);
		}

		public void AddRole(Role user)
		{
			_roleRepository.AddRole(user);
		}

		public void AddUser(User user)
		{
			_userRepository.AddUser(user);
		}

		public Task AddUserAsync(User user)
		{
			return _userRepository.AddUserAsync(user);
		}

		public void DeleteComment(Comment comment)
		{
			_commentRepository.DeleteComment(comment);
		}

		public void DeleteJob(Job job)
		{
			_jobRepository.DeleteJob(job);
		}

		public void DeleteProject(Project project)
		{
			_projectRepository.DeleteProject(project);
		}

		public void DeleteReview(Review review)
		{
			_reviewRepository.DeleteReview(review);
		}

		public void DeleteRole(Role role)
		{
			_roleRepository.DeleteRole(role);
		}

		public void DeleteUser(User user)
		{
			_userRepository.DeleteUser(user);
		}

		public List<Comment> GetAllComments()
		{
			return _commentRepository.GetAllComments();
		}

		public List<Job> GetAllJobs()
		{
			return _jobRepository.GetAllJobs();
		}

		public List<Project> GetAllProjects()
		{
			return _projectRepository.GetAllProjects();
		}

		public List<Review> GetAllReviews()
		{
			return _reviewRepository.GetAllReviews();
		}

		public List<Role> GetAllRoles()
		{
			return _roleRepository.GetAllRoles();
		}

		public List<User> GetAllUsers()
		{
			return _userRepository.GetAllUsers();
		}

		public Comment GetCommentById(int id)
		{
			return _commentRepository.GetCommentById(id);
		}

		public Job GetJobById(int id)
		{
			return _jobRepository.GetJobById(id);
		}

		public Project GetProjectById(int id)
		{
			return _projectRepository.GetProjectById(id);
		}

		public List<Comment> GetProjectComments(int projectId)
		{
			return _commentRepository.GetProjectComments(projectId);
		}

		public List<Job> GetProjectJobs(int porjectId)
		{
			return _jobRepository.GetProjectJobs(porjectId);
		}

		public Review GetReviewById(int id)
		{
			return _reviewRepository.GetReviewById(id);
		}

		public Role GetRoleById(int id)
		{
			return _roleRepository.GetRoleById(id);
		}

		public User GetUserByEmail(string email)
		{
			return _userRepository.GetUserByEmail(email);
		}

		public Task<User> GetUserByEmailAsync(string email)
		{
			return _userRepository.GetUserByEmailAsync(email);
		}

		public List<Comment> GetUserComments(string userEmail)
		{
			return _commentRepository.GetUserComments(userEmail);
		}

		public List<Job> GetUserJobs(string userEmail)
		{
			return _jobRepository.GetUserJobs(userEmail);
		}

		public List<Project> GetUserProjects(string userEmail)
		{
			return _projectRepository.GetUserProjects(userEmail);
		}

		public List<Review> GetUserReviews(string userEmail)
		{
			return _reviewRepository.GetUserReviews(userEmail);
		}

		public List<Comment> PageComments(int skip, int take)
		{
			return _commentRepository.PageComments(skip, take);
		}

		public List<Job> PageJobs(int skip, int take)
		{
			return _jobRepository.PageJobs(skip, take);
		}

		public List<Project> PageProjects(int skip, int take)
		{
			return _projectRepository.PageProjects(skip, take);
		}

		public List<Review> PageReviews(int skip, int take)
		{
			return _reviewRepository.PageReviews(skip, take);
		}

		public List<User> PageUsers(int skip, int take)
		{
			return _userRepository.PageUsers(skip, take);
		}

		public void UpdateComment(Comment comment)
		{
			_commentRepository.UpdateComment(comment);
		}

		public void UpdateJob(Job job)
		{
			_jobRepository.UpdateJob(job);
		}

		public void UpdateProject(Project project)
		{
			_projectRepository.UpdateProject(project);
		}

		public void UpdateReview(Review review)
		{
			_reviewRepository.UpdateReview(review);
		}

		public void UpdateRole(Role role)
		{
			_roleRepository.UpdateRole(role);
		}

		public void UpdateUser(User user)
		{
			_userRepository.UpdateUser(user);
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
