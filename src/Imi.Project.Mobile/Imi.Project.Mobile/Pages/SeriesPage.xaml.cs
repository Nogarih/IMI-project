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
    public partial class SeriesPage : ContentPage
    {
        private readonly ISerieService _serieService;

        public SeriesPage()
        {
            InitializeComponent();
        }
    }
}