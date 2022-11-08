namespace Imi.Project.Api.Core.Entities
{
    public class Anime : WatchItem
    {
        public int Seasons { get; set; }
        public int TotalEpisodes { get; set; }
        public bool HasSub { get; set; }
    }
}