namespace APIFun.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowler { get; }
    }
}
