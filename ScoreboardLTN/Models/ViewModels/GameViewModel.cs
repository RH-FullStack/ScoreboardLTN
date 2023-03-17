﻿using ScoreboardLTN.Controllers;

namespace ScoreboardLTN.Models.ViewModels
{
    public class GameViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Team>? Teams { get; set; }
    }
}
