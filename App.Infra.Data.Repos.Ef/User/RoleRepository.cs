

using App.Domain.Core.Users.Contract.Repositories;
using App.Domain.Core.Users.Entities;
using App.Infra.Data.SqlServer.Ef.Models;
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace App.Infra.Data.Repos.Ef.User;

public class RoleRepository : BaseRepository<Role>, IRoleRepository
{
        private readonly IQueryable<Role> _queryable;
    public RoleRepository(Maktab97ShopDbContext dbContext) : base(dbContext)
    {

    }
    public override async Task<IEnumerable<Role>> GetByFilterAsync(Expression<Func<Role, bool>> predicate)
    {

        return await _queryable.Where(predicate).Include(i => i.Permissions).ToArrayAsync();
    }

    //public async Task<List<Permission>> GetPermissionsByRoleId(int id, CancellationToken cancellation = default)
    //{
    //    var permissions = await _context.Roles.Where(i => i.Id == id)
    //                        .Include(i => i.Permissions)
    //                        .SelectMany(i => i.Permissions).ToListAsync(cancellation);
    //    return permissions;
    //}

    //public async Task<List<Role>> GetRolesByUserId(int userId)
    //{
    //   var roles = await _context.Users.Where(u => u.Id == userId).Include(u => u.Roles).SelectMany(r => r.Roles).ToListAsync();
       
                                 
    //    return roles;
    //}


}
