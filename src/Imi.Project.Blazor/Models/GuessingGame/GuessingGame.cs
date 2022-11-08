using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Models.GuessingGame
{
    public class GuessingGame
    {
        public bool IsFinished { get; set; }
        public IQueryable<GameItem> GameItems { get; set; }
        public int PlayerLives { get; set; } = 3;
        public IQueryable<char> RandomLetters { get; set; }
        public IQueryable<char> ValidLetters { get; set; }
        public string CurrentItemName { get; set; }

    }
}
