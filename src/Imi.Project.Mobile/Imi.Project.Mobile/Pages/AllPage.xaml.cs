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
    public partial class AllPage : ContentPage
    {
        private readonly MockItemService _mockItemService;
        public AllPage()
        {
            InitializeComponent();
            _mockItemService = new MockItemService();
            AddItems();
        }

        private async void AddItems()
        {
            watchItems.ItemsSource = await _mockItemService.GetWatchItems();
        }

        private void WatchItems_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}