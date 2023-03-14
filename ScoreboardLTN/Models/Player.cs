namespace ScoreboardLTN.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GamerTag { get; set; }
        public int? TeamId { get; set; }
        public Team? Team { get; set; }
    }
}
