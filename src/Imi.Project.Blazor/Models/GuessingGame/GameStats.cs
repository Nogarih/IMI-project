using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Models.GuessingGame
{
    public class GameStats
    {
        public IQueryable<int> HighScores { get; set; }
        public int GamesWon { get; set; }
        public int GamesLost { get; set; }
        public int TotalGamesPlayed { get; set; }
        public DateTime StartTime { get; set; }
    }
}
