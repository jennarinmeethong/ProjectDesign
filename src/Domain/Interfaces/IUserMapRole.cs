namespace ProjectDesign.Domain.Interfaces;
public interface IUserMapRole : IStamp
{
    Guid UserProfileId { get; set; }
    short RoleId { get; set; }
}