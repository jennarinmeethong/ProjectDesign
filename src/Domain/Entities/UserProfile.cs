namespace ProjectDesign.Domain.Entities;
[PrimaryKey(nameof(Id))]
[Index(nameof(Username), IsUnique = true)]
[Index(nameof(Email), IsUnique = true)]
public class UserProfile : IUserProfile
{
    public Guid Id { get; set; }
    [MaxLength(50)]
    public string Username { get; set; } = string.Empty;
    [MaxLength(50)]
    public string Password { get; set; } = string.Empty;
    [MaxLength(50)]
    public string Email { get; set; } = string.Empty;
    [MaxLength(50)]
    public string Firstname { get; set; } = string.Empty;
    [MaxLength(50)]
    public string Lastname { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public short GenderId { get; set; }
    public bool IsVerified { get; set; }
    public bool IsDisabled { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
    [ForeignKey(nameof(GenderId))]
    public virtual Gender Gender { get; set; } = null!;
    public virtual ICollection<UserMapRole> UserMapRoles { get; set; } = [];
}
