using GOLDEN_OWL_SOLUTIONS.Models;

namespace GOLDEN_OWL_SOLUTIONS.Intfs
{
    public interface IScoresService
    {
        Task<IEnumerable<Scores>> GetAllScoresAsync();
        Task<Scores> GetScoresBySbdAsync(string sbd);
        Task<IEnumerable<Scores>> GetTop10StudentsAsync();
        Task<Dictionary<string, Dictionary<string, int>>> GetScoreLevelReportAsync();


    }
}
