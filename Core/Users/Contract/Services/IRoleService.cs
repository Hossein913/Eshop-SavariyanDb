﻿using App.Domain.Core.Users.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Users.Contract.Services
{
    public interface IRoleService
    {
        Task<IdentityResult> RegisterRole(AddRoleDto roleModel);
    }
}
