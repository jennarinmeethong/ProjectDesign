

namespace ProjectDesign.Domain.Entities;
[PrimaryKey(nameof(Id))]
[Index(nameof(Seq))]
public class Role : IRole
{
    public short Id { get; set; }
    public short Seq { get; set; }
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    [MaxLength(50)]
    public string Description { get; set; } = string.Empty;
    public bool IsDisabled { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
}