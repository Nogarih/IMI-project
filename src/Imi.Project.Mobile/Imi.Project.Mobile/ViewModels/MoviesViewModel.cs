using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class MoviesViewModel : FreshBasePageModel
    {
        private readonly IMovieService _movieService;

        public MoviesViewModel(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // Properties
        private ObservableCollection<Movie> movies;
        public ObservableCollection<Movie> Movies
        {
            get { return movies; }
            set
            {
                movies = value;
                RaisePropertyChanged(nameof(Movies));
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

        // Commands

        public ICommand MovieListItemTapped => new Command<Movie>(
           async (Movie movie) =>
           {
               if (movie == null) return;
               await CoreMethods.PushPageModel<MovieDetailsViewModel>(movie);
           }
        );
        public ICommand CreateMovieClicked => new Command(
           async () =>
           {
               await CoreMethods.PushPageModel<CreateMovieViewModel>();
           }
        );

        public async override void Init(object initData)
        {
            base.Init(initData);
            Movies = new ObservableCollection<Movie>(await _movieService.GetMovies());
        }
    }
}