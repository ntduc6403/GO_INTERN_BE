using GOLDEN_OWL_SOLUTIONS.Models;
using Microsoft.EntityFrameworkCore;


namespace GOLDEN_OWL_SOLUTIONS.Data
{
    public class Scores_DbContext : DbContext
    {
        public Scores_DbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Scores> Scores { get; set; }
    }
}
