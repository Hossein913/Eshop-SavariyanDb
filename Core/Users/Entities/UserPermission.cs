using System;
using System.Collections.Generic;

namespace App.Domain.Core.Users.Entities;

public partial class UserPermission
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int PermissionId { get; set; }

    public bool PermissionMode { get; set; }

    public virtual Permission Permission { get; set; } = null!;

    public virtual ApplicationUser User { get; set; } = null!;
}
