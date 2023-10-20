using App.Domain.Core.Users.Contract.Services;
using App.Domain.Core.Users.Dtos;
using App.Domain.Core.Users.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.User
{
    public class RoleService : IRoleService
    {
        protected readonly RoleManager<Role> _roleManager;
        public RoleService(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<IdentityResult> RegisterRole(AddRoleDto roleModel)
        {
            Role role = new Role { Name = roleModel.Name };


            var result = await _roleManager.CreateAsync(role);
            return result;

        }

    }
}
