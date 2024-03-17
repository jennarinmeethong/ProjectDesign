
namespace ProjectDesign.Domain.Entities;
[PrimaryKey(nameof(UserProfileId), nameof(RoleId))]
[Index(nameof(UserProfileId), nameof(RoleId), IsUnique = true)]
public class UserMapRole : IUserMapRole
{
    public Guid UserProfileId { get; set; }
    public short RoleId { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
    [ForeignKey(nameof(UserProfileId))]
    public virtual UserProfile UserProfile { get; set; } = new();
    [ForeignKey(nameof(RoleId))]
    public virtual Role Role { get; set; } = new();
}
