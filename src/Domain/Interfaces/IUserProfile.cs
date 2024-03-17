namespace ProjectDesign.Domain.Interfaces
{
    internal interface IUserProfile : IStamp
    {
        Guid Id { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        DateTime BirthDate { get; set; }
        short GenderId { get; set; }
        bool IsVerified { get; set; }
        bool IsDisabled { get; set; }
    }
}
