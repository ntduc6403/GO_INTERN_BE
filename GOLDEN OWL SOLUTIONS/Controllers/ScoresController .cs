using GOLDEN_OWL_SOLUTIONS.Intfs;
using GOLDEN_OWL_SOLUTIONS.Models;
using Microsoft.AspNetCore.Mvc;

namespace GOLDEN_OWL_SOLUTIONS.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class ScoresController : ControllerBase
    {
        private readonly IScoresService _scoresService;
        public ScoresController(IScoresService scoresService)
        {
            _scoresService = scoresService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Scores>>> GetDiemThis()
        {
            return Ok(await _scoresService.GetAllScoresAsync());
        }


  
        [HttpGet("{sbd}")]
        public async Task<ActionResult<Scores>> GetDiemThi(string sbd)
        {
            var diemThi = await _scoresService.GetScoresBySbdAsync(sbd);
            if (diemThi == null)
            {
                return NotFound();
            }
            return Ok(diemThi);
        }

        [HttpGet("top10")]
        public async Task<ActionResult<IEnumerable<Scores>>> GetTop10Students()
        {
            return Ok(await _scoresService.GetTop10StudentsAsync());
        }

        [HttpGet("score-level-report")]
        public async Task<ActionResult<Dictionary<string, Dictionary<string, int>>>> GetScoreLevelReport()
        {
            var report = await _scoresService.GetScoreLevelReportAsync();
            return Ok(report);
        }
    }


}

