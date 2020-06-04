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

		public void AddJob(Job user)
		{
			throw new NotImplementedException();
		}

		public void DeleteJob(Job job)
		{
			throw new NotImplementedException();
		}

		public List<Job> GetAllJobs()
		{
			throw new NotImplementedException();
		}

		public Job GetJobById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Job> GetProjectJobs(int porjectId)
		{
			throw new NotImplementedException();
		}

		public List<Job> GetUserJobs(string userEmail)
		{
			throw new NotImplementedException();
		}

		public List<Job> PageJobs(int skip, int take)
		{
			throw new NotImplementedException();
		}

		public void UpdateJob(Job job)
		{
			throw new NotImplementedException();
		}
	}
}
