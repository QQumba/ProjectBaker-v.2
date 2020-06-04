using ProjectBaker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBaker.Domain.Repositories
{
	public interface IProjectRepository
	{
		void AddProject(Project project);
		Project GetProjectById(int id);
		List<Project> GetAllProjects();
		List<Project> GetUserProjects(string userEmail);
		List<Project> PageProjects(int skip, int take);
		void UpdateProject(Project project);
		void DeleteProject(Project project);
	}
}
