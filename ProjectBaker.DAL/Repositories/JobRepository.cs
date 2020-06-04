using Microsoft.EntityFrameworkCore;
using ProjectBaker.Domain.Entities;
using ProjectBaker.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectBaker.DAL.Repositories
{
	public class JobRepository : IJobRepository
	{
		private AppDbContext _db;

		public JobRepository(AppDbContext context)
		{
			_db = context;
		}

		private DbSet<Job> Set
		{
			get { return _db.Jobs; }
		}

		public void AddJob(Job job)
		{
			Set.Add(job);
		}

		public void DeleteJob(Job job)
		{
			Set.Remove(job);
		}

		public List<Job> GetAllJobs()
		{
			return Set.Select(j => j).ToList();
		}

		public Job GetJobById(int id)
		{
			return Set.FirstOrDefault(j => j.Id == id);
		}

		public List<Job> GetProjectJobs(int projectId)
		{
			return Set.Select(j => j).Where(j => j.ProjectId == projectId).ToList();
		}

		public List<Job> GetUserJobs(string userEmail)
		{
			return Set.Select(j => j).Where(j => j.EmployeeEmail == userEmail).ToList();
		}

		public List<Job> PageJobs(int skip, int take)
		{
			return Set.Skip(skip).Take(take).ToList();
		}

		public void UpdateJob(Job job)
		{
			Set.Update(job);
		}
	}
}
