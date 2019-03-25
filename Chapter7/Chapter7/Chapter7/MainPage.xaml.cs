using System;
using System.Collections.Generic;
using System.Linq;
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

            this.mainPageViewModel = new MainPageViewModel
            {
                Items = new List<ItemModel>
                {
                    new ItemModel(1, "Pizza", 5),
                    new ItemModel(2, "Burger", 3)
                }
            };

            this.BindingContext = mainPageViewModel;
        }

        private async void OnAddItemClicked(object sender, EventArgs e)
        {
            var addPage = new AddItemPage(this.mainPageViewModel);
            await Navigation.PushAsync(addPage);
        }
    }
}
