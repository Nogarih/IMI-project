using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class CreateSerieViewModel : FreshBasePageModel
    {
        private readonly ISerieService _serieService;
        private readonly IWatchStatusService _watchStatusService;
        private readonly IGenreService _genreService;
        private readonly ILanguageService _languageService;

        public CreateSerieViewModel(ISerieService serieService, IWatchStatusService watchStatusService, IGenreService genreService, ILanguageService languageService)
        {
            _serieService = serieService;
            _watchStatusService = watchStatusService;
            _genreService = genreService;
            _languageService = languageService;
        }

        // Properties
        private Serie selectedSerie;
        public Serie SelectedSerie
        {
            get { return selectedSerie; }
            set
            {
                selectedSerie = value;
                RaisePropertyChanged(nameof(SelectedSerie));
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
        private ImageSource serieImageSrc;
        public ImageSource SerieImageSrc
        {
            get { return serieImageSrc; }
            set
            {
                serieImageSrc = value;
                RaisePropertyChanged(nameof(SerieImageSrc));
            }
        }
        private FileResult serieImage;
        public FileResult SerieImage
        {
            get { return serieImage; }
            set
            {
                serieImage = value;
                RaisePropertyChanged(nameof(SerieImage));
            }
        }
        private string seasons;
        public string Seasons 
        {
            get { return Seasons; } 
            set
            {
                Seasons = value;
                RaisePropertyChanged(nameof(Seasons));
            }
        }
        private string watchedEpisodes;
        public string WatchedEpisodes 
        {
            get { return watchedEpisodes; }
            set 
            { 
                watchedEpisodes = value;
                RaisePropertyChanged(nameof(WatchedEpisodes));
            }
        }
        private string totalEpisodes;

        public string TotalEpisodes 
        {
            get { return totalEpisodes; }
            set
            {
                totalEpisodes = value;
                RaisePropertyChanged(nameof(TotalEpisodes));
            }
        }

        // Commands
        public ICommand CreateSerieButtonTapped => new Command(
            async () =>
            {
                if (!string.IsNullOrWhiteSpace(Title))
                {
                    Serie newSerie = new Serie();
                    newSerie.Title = Title;
                    newSerie.ReleaseYear = ReleaseYear;
                    newSerie.WatchStatusId = SelectedWatchStatus.Id;
                    newSerie.GenreId = SelectedGenre.Id;
                    newSerie.LanguageId = SelectedLanguage.Id;
                    newSerie.Description = Description;
                    newSerie.Seasons = Seasons;
                    newSerie.TotalEpisodes = TotalEpisodes;
                    newSerie.TotalEpisodes = TotalEpisodes;

                    if (SerieImage != null)
                    {
                        var imageStream = await SerieImage.OpenReadAsync();
                        newSerie.Image = imageStream.ToString();
                    }

                    await _serieService.AddSerie(newSerie);
                    await CoreMethods.DisplayAlert("Success", "Serie added", "Ok");
                    await CoreMethods.PushPageModel<SeriesViewModel>();
                }
                else
                    await CoreMethods.DisplayAlert("Invalid title", "Enter valid serie title", "Cancel");
            }
        );

        public ICommand TakePhotoButtonTapped => new Command(
            async () =>
            {
                var result = await MediaPicker.CapturePhotoAsync();
                if (result != null)
                {
                    SerieImage = result;
                    var stream = await result.OpenReadAsync();
                    SerieImageSrc = ImageSource.FromStream(() => stream);
                }
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
                    SerieImage = result;
                    var stream = await result.OpenReadAsync();
                    SerieImageSrc = ImageSource.FromStream(() => stream);
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