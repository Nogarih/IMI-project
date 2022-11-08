using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class CreateMovieViewModel : FreshBasePageModel
    {
        private readonly IMovieService _movieService;
        private readonly IWatchStatusService _watchStatusService;
        private readonly IGenreService _genreService;
        private readonly IDirectorService _directorService;
        private readonly ILanguageService _languageService;

        public CreateMovieViewModel(IMovieService movieService, IWatchStatusService watchStatusService, IGenreService genreService, IDirectorService directorService, ILanguageService languageService)
        {
            _movieService = movieService;
            _watchStatusService = watchStatusService;
            _genreService = genreService;
            _directorService = directorService;
            _languageService = languageService;
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
        private string director;
        public string Director
        {
            get { return director; }
            set
            {
                director = value;
                RaisePropertyChanged(nameof(Director));
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
        private ObservableCollection<Language> languages;
        public ObservableCollection<Language> Languages
        {
            get { return languages; }
            set
            {
                languages = value;
                RaisePropertyChanged(nameof(Languages));
            }
        }
        private Language selectedLanguage;
        public Language SelectedLanguage
        {
            get { return selectedLanguage; }
            set
            {
                selectedLanguage = value;
                RaisePropertyChanged(nameof(SelectedLanguage));
            }
        }
        private ObservableCollection<Genre> genres;
        public ObservableCollection<Genre> Genres
        {
            get { return genres; }
            set
            {
                genres = value;
                RaisePropertyChanged(nameof(Genres));
            }
        }

        private Genre selectedGenre;
        public Genre SelectedGenre
        {
            get { return selectedGenre; }
            set
            {
                selectedGenre = value;
                RaisePropertyChanged(nameof(SelectedGenre));
            }
        }
        private ObservableCollection<WatchStatus> watchStatuses;
        public ObservableCollection<WatchStatus> WatchStatuses
        {
            get { return watchStatuses; }
            set
            {
                watchStatuses = value;
                RaisePropertyChanged(nameof(WatchStatuses));
            }
        }
        private WatchStatus selectedWatchStatus;
        public WatchStatus SelectedWatchStatus
        {
            get { return selectedWatchStatus; }
            set
            {
                selectedWatchStatus = value;
                RaisePropertyChanged(nameof(SelectedWatchStatus));
            }
        }
        private ImageSource movieImageSrc;
        public ImageSource MovieImageSrc
        {
            get { return movieImageSrc; }
            set
            {
                movieImageSrc = value;
                RaisePropertyChanged(nameof(MovieImageSrc));
            }
        }
        private FileResult movieImage;
        public FileResult MovieImage
        {
            get { return movieImage; }
            set
            {
                movieImage = value;
                RaisePropertyChanged(nameof(MovieImage));
            }
        }

        // Commands
        public ICommand CreateMovieButtonTapped => new Command(
            async () =>
            {
                if (!string.IsNullOrWhiteSpace(Title))
                {
                    Movie movie = new Movie();
                    movie.Title = Title;
                    movie.ReleaseYear = ReleaseYear;
                    movie.WatchStatusId = SelectedWatchStatus.Id;
                    movie.GenreId = SelectedGenre.Id;
                    movie.LanguageId = SelectedLanguage.Id;
                    movie.Description = Description;
                    movie.DirectorId = _directorService.AddDirector(Director).Id;

                    if (MovieImage != null)
                    {
                        var imageStream = await MovieImage.OpenReadAsync();
                        movie.Image = imageStream.ToString();
                    }

                    await _movieService.AddMovie(movie);
                    await CoreMethods.DisplayAlert("Success", "Movie added", "Ok");
                    await CoreMethods.PushPageModel<MoviesViewModel>();
                }
                else
                    await CoreMethods.DisplayAlert("Invalid title", "Enter valid movie title", "Cancel");
            }
        );
        
        public ICommand UploadImageButtonTapped => new Command(
            async () =>
            {
                var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
                {
                    Title = "Select an image"
                });
                if (result != null)
                {
                    MovieImage = result;
                    var stream = await result.OpenReadAsync();
                    MovieImageSrc = ImageSource.FromStream(() => stream);
                }
            }
        );

        public ICommand TakePhotoButtonTapped => new Command(
            async () =>
            {
                var result = await MediaPicker.CapturePhotoAsync();
                if (result != null)
                {
                    MovieImage = result;
                    var stream = await result.OpenReadAsync();
                    MovieImageSrc = ImageSource.FromStream(() => stream);
                }
            }
        );

        public async override void Init(object initData)
        {
            base.Init(initData);

            WatchStatuses = new ObservableCollection<WatchStatus>(await _watchStatusService.GetStatusList());
            Genres = new ObservableCollection<Genre>(await _genreService.GetGenresList());
            Languages = new ObservableCollection<Language>(await _languageService.GetLanguagesList());
        }
    }
}