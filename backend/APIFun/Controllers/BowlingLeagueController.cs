using APIFun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIFun.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        public IBowlingRepository _bowlingRepository;
        public BowlingLeagueController(IBowlingRepository temp) {
            _bowlingRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlingData = _bowlingRepository.Bowler.ToArray();

            return bowlingData;
        }
    }
}
