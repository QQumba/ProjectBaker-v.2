using ProjectBaker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBaker.Domain.Repositories
{
	public interface IJobRepository
	{
		void AddJob(Job user);
		Job GetJobById(int id);
		List<Job> GetAllJobs();
		List<Job> GetProjectJobs(int porjectId);
		List<Job> GetUserJobs(string userEmail);
		List<Job> PageJobs(int skip, int take);
		void UpdateJob(Job job);
		void DeleteJob(Job job);

	}
}
