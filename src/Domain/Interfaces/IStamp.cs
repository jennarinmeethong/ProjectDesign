namespace ProjectDesign.Domain.Interfaces;
public interface IStamp
{
    Guid CreatedBy { get; set; }
    DateTime CreatedAt { get; set; }
    Guid? ModifiedBy { get; set; }
    DateTime? ModifiedAt { get; set; }
}