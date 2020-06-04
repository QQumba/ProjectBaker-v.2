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

		public void AddRole(Role user)
		{
			throw new NotImplementedException();
		}

		public void DeleteRole(Role role)
		{
			throw new NotImplementedException();
		}

		public List<Role> GetAllRoles()
		{
			throw new NotImplementedException();
		}

		public Role GetRoleById(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateRole(Role role)
		{
			throw new NotImplementedException();
		}
	}
}
