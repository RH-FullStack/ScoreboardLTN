using System.ComponentModel.DataAnnotations.Schema;

namespace ScoreboardLTN.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Player>? Players { get; set; }
        public string? Score { get; set; }
        public string? Time { get; set; }
        public int? GameId { get; set; }
        public Game? Game { get; set; }
    }
}
