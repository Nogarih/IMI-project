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
    public partial class ToWatchPage : ContentPage
    {
        private readonly MockItemService _mockItemService;
        public ToWatchPage()
        {
            InitializeComponent();
            _mockItemService = new MockItemService();
            AddItems();
        }
        private async void AddItems()
        {
            var allItems = await _mockItemService.GetWatchItems();

            var allWatchedItems = allItems.Where(item => item.WatchStatusId == Guid.Parse("00000000-0000-0000-0000-000000000002"));
            watchItems.ItemsSource = allWatchedItems;
        }
    }
}