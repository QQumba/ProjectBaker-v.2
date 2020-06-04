using Microsoft.EntityFrameworkCore;
using ProjectBaker.Domain.Entities;
using ProjectBaker.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectBaker.DAL.Repositories
{
	public class RoleRepository : IRoleRepository
	{
		private AppDbContext _db;

		public RoleRepository(AppDbContext context)
		{
			_db = context;
		}

		protected DbSet<Role> Set
		{
			get { return _db.Roles; }
		}

		public void AddRole(Role role)
		{
			Set.Add(role);
		}

		public void DeleteRole(Role role)
		{
			Set.Remove(role);
		}

		public List<Role> GetAllRoles()
		{
			return Set.Select(r => r).ToList();
		}

		public Role GetRoleById(int id)
		{
			return Set.FirstOrDefault(r => r.Id == id);
		}

		public void UpdateRole(Role role)
		{
			Set.Update(role);
		}
	}
}
