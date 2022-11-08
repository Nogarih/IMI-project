using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class MovieDetailsViewModel : FreshBasePageModel
    {
        private readonly IMovieService _movieService;

        public MovieDetailsViewModel(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // Properties
        private Movie selectedMovie;
        public Movie SelectedMovie
        {
            get { return selectedMovie; }
            set
            {
                selectedMovie = value;
                RaisePropertyChanged(nameof(SelectedMovie));
            }
        }

        // Commands
        public ICommand EditMovieButtonTapped => new Command(
           async () =>
           {
               if (SelectedMovie == null) return;
               await CoreMethods.PushPageModel<CreateMovieViewModel>(SelectedMovie);

           }
        );
        public ICommand DeleteMovieButtonTapped => new Command(
            async () =>
            {
                if (SelectedMovie == null) return;
                var confirmed = await CoreMethods.DisplayAlert("Delete movie?", $"Do you want to delete {selectedMovie.Title} ?", "Yes, delete!", "No");
                if (confirmed)
                {
                    await _movieService.DeleteMovie(SelectedMovie.Id);
                    await CoreMethods.PushPageModel<MoviesViewModel>();
                }
            }
        );

        public async override void Init(object initData)
        {
            base.Init(initData);
            SelectedMovie = await _movieService.GetMovieDetails((initData as Movie).Id);
        }
    }
}