namespace BIT.LogService.Interfaces
{
    public interface IMemLogConfiguration
    {
        int Capacity { get; }
        string Level { get; }
    }
}
