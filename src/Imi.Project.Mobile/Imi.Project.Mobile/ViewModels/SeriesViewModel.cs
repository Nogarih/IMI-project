using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class SeriesViewModel : FreshBasePageModel
    {
        private readonly ISerieService _serieService;

        public SeriesViewModel(ISerieService serieService)
        {
            _serieService = serieService;
        }

        // Properties
        private ObservableCollection<Serie> series;
        public ObservableCollection<Serie> Series
        {
            get { return series; }
            set
            {
                series = value;
                RaisePropertyChanged(nameof(Series));
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
        public ICommand SerieListItemTapped => new Command<Serie>(
           async (Serie serie) =>
           {
               if (serie == null) return;
               await CoreMethods.PushPageModel<SerieDetailViewModel>(serie);
           }
        );
        public ICommand CreateSerieClicked => new Command(
           async () =>
           {
               await CoreMethods.PushPageModel<CreateSerieViewModel>();
           }
        );

        public async override void Init(object initData)
        {
            base.Init(initData);
            Series = new ObservableCollection<Serie>(await _serieService.GetSeries());
        }
    }
}