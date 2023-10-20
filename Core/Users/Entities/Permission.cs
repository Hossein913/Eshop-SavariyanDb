namespace App.Domain.Core.Users.Entities;

public class Permission
{
    public int Id { get; set; }

    public string Title { get; set; }

    public int? ParentId { get; set; }

    public List<Role> Roles { get; set; }

    public virtual ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();

}
