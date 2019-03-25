using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter7
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel mainPageViewModel;

        public MainPage()
        {
            InitializeComponent();

            using (var client = new HttpClient())
            {
                var data = client.GetStringAsync("http://localhost:5000/api/values").Result;
                var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ItemModel>>(data);

                this.mainPageViewModel = new MainPageViewModel
                {
                    Items = new ObservableCollection<ItemModel>(list)
                };
            }
            
            this.BindingContext = mainPageViewModel;
        }

        private async void OnAddItemClicked(object sender, EventArgs e)
        {
            var addPage = new AddItemPage(this.mainPageViewModel);
            await Navigation.PushAsync(addPage);
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ItemModel;
            var editPage = new EditPage(item);
            await Navigation.PushAsync(editPage);
        }
    }
}
