using ProjectBaker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBaker.Domain.Repositories
{
	public interface IRoleRepository
	{
		void AddRole(Role user);
		Role GetRoleById(int id);
		List<Role> GetAllRoles();
		void UpdateRole(Role role);
		void DeleteRole(Role role);
	}
}
