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
	}
}
