using App.Domain.Core.Users.Contract.AppServices;
using App.Domain.Core.Users.Contract.Services;
using App.Domain.Core.Users.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Users
{
    public class RoleAppService: IRoleAppService
    {
        protected readonly IRoleService roleService;

        public RoleAppService(IRoleService roleService)
        {
            this.roleService = roleService;
        }

        public async Task<IdentityResult> RegisterRole(AddRoleDto roleModel)
        {
            var result = await roleService.RegisterRole(roleModel);
            return result;
        }
    }
}
