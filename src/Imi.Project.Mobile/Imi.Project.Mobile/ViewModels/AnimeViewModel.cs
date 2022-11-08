using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System.Collections.ObjectModel;

namespace Imi.Project.Mobile.ViewModels
{
    public class AnimeViewModel : FreshBasePageModel
    {
        private readonly IAnimeService _animeService;
        public AnimeViewModel(IAnimeService animeService)
        {
            _animeService = animeService;
        }

        // Properties
        private ObservableCollection<Anime> animes;
        public ObservableCollection<Anime> Animes
        {
            get { return animes; }
            set
            {
                animes = value;
                RaisePropertyChanged(nameof(Animes));
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                RaisePropertyChanged(nameof(Title));
            }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                RaisePropertyChanged(nameof(Description));
            }
        }

        private string releaseYear;
        public string ReleaseYear
        {
            get { return releaseYear; }
            set
            {
                releaseYear = value;
                RaisePropertyChanged(nameof(ReleaseYear));
            }
        }

        private string image;
        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                RaisePropertyChanged(nameof(Image));
            }
        }
    }
}