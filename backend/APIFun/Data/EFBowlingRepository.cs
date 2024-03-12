namespace APIFun.Data
{
    public class EFBowlingRepository :IBowlingRepository
    {
        private BowlingLeagueContext _bowlingContext;

        public EFBowlingRepository(BowlingLeagueContext temp) {
            _bowlingContext = temp;
        }

        public IEnumerable<Bowler> Bowler => _bowlingContext.Bowlers;
    }
}
