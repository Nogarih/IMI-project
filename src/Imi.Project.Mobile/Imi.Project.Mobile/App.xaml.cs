using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using Imi.Project.Mobile.ViewModels;
using Xamarin.Forms;

namespace Imi.Project.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeIOC();

            // Add tapped pages , change afterwards to tapped viewmodel!!
            var mainPage = new FreshTabbedNavigationContainer();
            mainPage.AddTab<MoviesViewModel>("Movies", "movies_icon.png");
            mainPage.AddTab<SeriesViewModel>("Series", "series_icon.png");
            mainPage.AddTab<MoviesViewModel>("Animes", "anime_icon.png");
            mainPage.AddTab<MoviesViewModel>("WatchList", "list_icon.png");
            mainPage.Title = "MyWatchList";

            //MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<LoginViewModel>());
            MainPage = mainPage;
        }

        private void InitializeIOC()
        {
            //register dependencies
            FreshIOC.Container.Register<IMovieService>(new MockMovieService());
            FreshIOC.Container.Register<ISerieService>(new MockSerieService());
            FreshIOC.Container.Register<IWatchStatusService>(new MockWatchStatus());
            FreshIOC.Container.Register<IGenreService>(new MockGenreService());
            FreshIOC.Container.Register<IDirectorService>(new MockDirectorService());
            FreshIOC.Container.Register<ILanguageService>(new MockLanguageService());
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}