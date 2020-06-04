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

		public void AddProject(Project project)
		{
			_db.Projects.Add(project);
			_db.SaveChanges();
		}

		public Project GetProjectById(int id)
		{
			Project project = null;
			project = _db.Projects.First(p => p.Id == id);
			return project;
		}

		public List<Project> GetAllProjects()
		{
			List<Project> projects = null;
			projects = _db.Projects.Select(p => p).ToList();
			return projects;
		}
	}
}
