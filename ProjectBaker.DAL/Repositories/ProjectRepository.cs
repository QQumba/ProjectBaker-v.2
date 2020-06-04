using Microsoft.EntityFrameworkCore;
using ProjectBaker.Domain.Entities;
using ProjectBaker.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectBaker.DAL.Repositories
{
	public class ProjectRepository : IProjectRepository
	{
		private AppDbContext _db;

		public ProjectRepository(AppDbContext context)
		{
			_db = context;
		}

		private DbSet<Project> Set
		{
			get { return _db.Projects; }
		}

		public void AddProject(Project project)
		{
			Set.Add(project);
			_db.SaveChanges();
		}

		public Project GetProjectById(int id)
		{
			return Set.First(p => p.Id == id);
		}

		public List<Project> GetAllProjects()
		{
			return Set.Select(p => p).ToList();
		}

		public List<Project> GetUserProjects(string userEmail)
		{
			return Set.Select(p => p).Where(p => p.UserEmail == userEmail).ToList();
		}

		public List<Project> PageProjects(int skip, int take)
		{
			return Set.Skip(skip).Take(take).ToList();
		}

		public void UpdateProject(Project project)
		{
			Set.Update(project);
		}

		public void DeleteProject(Project project)
		{
			Set.Remove(project);
		}
	}
}
