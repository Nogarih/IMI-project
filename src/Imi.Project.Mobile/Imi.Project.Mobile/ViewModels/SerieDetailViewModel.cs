using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class SerieDetailViewModel : FreshBasePageModel
    {
        private readonly ISerieService _serieService;

        public SerieDetailViewModel(ISerieService serieService)
        {
            _serieService = serieService;
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

        // Commands
        public ICommand EditSerieButtonTapped => new Command(
           async () =>
           {
               if (SelectedSerie == null) return;
               await CoreMethods.PushPageModel<CreateSerieViewModel>(SelectedSerie);

           }
        );

        public ICommand DeleteSerieButtonTapped => new Command(
            async () =>
            {
                if (SelectedSerie == null) return;
                var confirmed = await CoreMethods.DisplayAlert("Delete serie?", $"Do you want to delete {selectedSerie.Title} ?", "Yes, delete!", "No");
                if (confirmed)
                {
                    await _serieService.DeleteSerie(SelectedSerie.Id);
                    await CoreMethods.PushPageModel<SeriesViewModel>();
                }
            }
        );

        public async override void Init(object initData)
        {
            base.Init(initData);
            SelectedSerie = await _serieService.GetSerieDetails((initData as Serie).Id);
        }
    }
}