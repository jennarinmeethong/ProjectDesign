namespace ProjectDesign.Domain.Interfaces;
public interface IGender : IStamp
{
    short Id { get; set; }
    short Seq { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    bool IsDisabled { get; set; }
}