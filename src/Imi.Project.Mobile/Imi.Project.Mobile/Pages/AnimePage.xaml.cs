using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimePage : ContentPage
    {
        private readonly IAnimeService _animeService;

        public AnimePage()
        {
            InitializeComponent();
            _animeService = new MockAnimeService();
        }
        protected override async void OnAppearing()
        {
            await RefreshAnimes();
            base.OnAppearing();
        }
        public async Task RefreshAnimes()
        {
            var animes = await _animeService.GetAnimes();
            animeList.FlowItemsSource = animes.ToList();
        }

        private async void btnCreateAnime_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateAnimePage());
        }
        private async void AnimeList_FlowItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedAnime = e.Item as Anime;
            await Navigation.PushAsync(new AnimeDetailPage(selectedAnime));
        }
    }
}