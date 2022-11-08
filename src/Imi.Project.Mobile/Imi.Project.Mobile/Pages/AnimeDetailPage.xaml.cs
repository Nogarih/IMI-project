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
    public partial class AnimeDetailPage : ContentPage
    {
        private readonly IAnimeService _animeService;
        public AnimeDetailPage(Anime anime)
        {
            InitializeComponent();
            BindingContext = anime;
            _animeService = new MockAnimeService();
        }

        private void BtnEditAnime_Clicked(object sender, EventArgs e)
        {

        }

        private async void BtnDeleteAnime_Clicked(object sender, EventArgs e)
        {
            var anime = (Anime)BindingContext;
            var result = await DisplayAlert("Deleting anime", $"Are you sure you want to delete {anime.Title}?", "Yes, delete!", "Cancel");
            if (result)
            {
                await _animeService.DeleteAnime(anime.Id);
                await Navigation.PopAsync();
            }
        }
    }
}