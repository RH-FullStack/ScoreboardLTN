using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ScoreboardLTN.Models;

namespace ScoreboardLTN.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
                
        }
        public DbSet<ScoreboardLTN.Models.Game> Game { get; set; }
        public DbSet<ScoreboardLTN.Models.Team> Team { get; set; }
        public DbSet<ScoreboardLTN.Models.Player> Player { get; set; }
    }
}