using GOLDEN_OWL_SOLUTIONS.Data;
using GOLDEN_OWL_SOLUTIONS.Intfs;
using GOLDEN_OWL_SOLUTIONS.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GOLDEN_OWL_SOLUTIONS.Impls
{
    public class ScoresService : IScoresService
    {
        private readonly Scores_DbContext _context;

        public ScoresService(Scores_DbContext context)
        {
            _context = context;
        }
        public Task AddScoresAsync(Scores sc)
        {
            throw new NotImplementedException();
        }

        public Task DeleteScoresAsync(string sbd)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Scores>> GetAllScoresAsync()
        {
            return await _context.Scores.ToListAsync();
        }

        public async Task<Scores> GetScoresBySbdAsync(string sbd)
        {
            return await _context.Scores.FindAsync(sbd);
        }

        public Task UpdateScoresAsync(string sbd, Scores sc)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Scores>> GetTop10StudentsAsync()
        {
            return await _context.Scores
                .OrderByDescending(s => s.toan + s.vat_li + s.hoa_hoc) 
                .Take(10) 
                .ToListAsync();
        }

        public async Task<Dictionary<string, Dictionary<string, int>>> GetScoreLevelReportAsync()
        {
            var report = new Dictionary<string, Dictionary<string, int>>
            {
                { "toan", new Dictionary<string, int> { { "8+", 0 }, { "6-8", 0 }, { "4-6", 0 }, { "<4", 0 } } },
                { "vat_li", new Dictionary<string, int> { { "8+", 0 }, { "6-8", 0 }, { "4-6", 0 }, { "<4", 0 } } },
                { "hoa_hoc", new Dictionary<string, int> { { "8+", 0 }, { "6-8", 0 }, { "4-6", 0 }, { "<4", 0 } } },
                { "ngu_van", new Dictionary<string, int> { { "8+", 0 }, { "6-8", 0 }, { "4-6", 0 }, { "<4", 0 } } },
                { "ngoai_ngu", new Dictionary<string, int> { { "8+", 0 }, { "6-8", 0 }, { "4-6", 0 }, { "<4", 0 } } },
                { "sinh_hoc", new Dictionary<string, int> { { "8+", 0 }, { "6-8", 0 }, { "4-6", 0 }, { "<4", 0 } } },
                { "lich_su", new Dictionary<string, int> { { "8+", 0 }, { "6-8", 0 }, { "4-6", 0 }, { "<4", 0 } } },
                { "dia_li", new Dictionary<string, int> { { "8+", 0 }, { "6-8", 0 }, { "4-6", 0 }, { "<4", 0 } } },
                { "gdcd", new Dictionary<string, int> { { "8+", 0 }, { "6-8", 0 }, { "4-6", 0 }, { "<4", 0 } } }
            };

            var scores = await _context.Scores.ToListAsync();

            foreach (var score in scores)
            {
                // Thống kê cho môn Toán
                if (score.toan >= 8) report["toan"]["8+"]++;
                else if (score.toan >= 6) report["toan"]["6-8"]++;
                else if (score.toan >= 4) report["toan"]["4-6"]++;
                else report["toan"]["<4"]++;

                // Thống kê cho môn Lý
                if (score.vat_li >= 8) report["vat_li"]["8+"]++;
                else if (score.vat_li >= 6) report["vat_li"]["6-8"]++;
                else if (score.vat_li >= 4) report["vat_li"]["4-6"]++;
                else report["vat_li"]["<4"]++;

                // Thống kê cho môn Hóa
                if (score.hoa_hoc >= 8) report["hoa_hoc"]["8+"]++;
                else if (score.hoa_hoc >= 6) report["hoa_hoc"]["6-8"]++;
                else if (score.hoa_hoc >= 4) report["hoa_hoc"]["4-6"]++;
                else report["hoa_hoc"]["<4"]++;

                // Thống kê cho môn Ngữ Văn
                if (score.ngu_van >= 8) report["ngu_van"]["8+"]++;
                else if (score.ngu_van >= 6) report["ngu_van"]["6-8"]++;
                else if (score.ngu_van >= 4) report["ngu_van"]["4-6"]++;
                else report["ngu_van"]["<4"]++;

                // Thống kê cho môn Ngoại Ngữ
                if (score.ngoai_ngu >= 8) report["ngoai_ngu"]["8+"]++;
                else if (score.ngoai_ngu >= 6) report["ngoai_ngu"]["6-8"]++;
                else if (score.ngoai_ngu >= 4) report["ngoai_ngu"]["4-6"]++;
                else report["ngoai_ngu"]["<4"]++;

                // Thống kê cho môn Sinh Học
                if (score.sinh_hoc >= 8) report["sinh_hoc"]["8+"]++;
                else if (score.sinh_hoc >= 6) report["sinh_hoc"]["6-8"]++;
                else if (score.sinh_hoc >= 4) report["sinh_hoc"]["4-6"]++;
                else report["sinh_hoc"]["<4"]++;

                // Thống kê cho môn Lịch Sử
                if (score.lich_su >= 8) report["lich_su"]["8+"]++;
                else if (score.lich_su >= 6) report["lich_su"]["6-8"]++;
                else if (score.lich_su >= 4) report["lich_su"]["4-6"]++;
                else report["lich_su"]["<4"]++;

                // Thống kê cho môn Địa Lý
                if (score.dia_li >= 8) report["dia_li"]["8+"]++;
                else if (score.dia_li >= 6) report["dia_li"]["6-8"]++;
                else if (score.dia_li >= 4) report["dia_li"]["4-6"]++;
                else report["dia_li"]["<4"]++;

                // Thống kê cho môn GDCD
                if (score.gdcd >= 8) report["gdcd"]["8+"]++;
                else if (score.gdcd >= 6) report["gdcd"]["6-8"]++;
                else if (score.gdcd >= 4) report["gdcd"]["4-6"]++;
                else report["gdcd"]["<4"]++;
            }

            return report;
        }
    }
}
