using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddItemPage : ContentPage
	{
        private readonly MainPageViewModel mainPageViewModel;
        private ItemModel addItemModel;

        public AddItemPage (MainPageViewModel mainPageViewModel)
		{
			InitializeComponent ();

            addItemModel = new ItemModel();
            this.BindingContext = addItemModel;
            this.mainPageViewModel = mainPageViewModel;
        }

        private async void OnAddItem(object sender, EventArgs e)
        {
            this.addItemModel.Id = this.mainPageViewModel.Items.Count + 1;
            this.mainPageViewModel.Items.Add(this.addItemModel);

            using (var client = new HttpClient())
            {
                await client.PostAsJsonAsync("http://localhost:5000/api/values", this.addItemModel);
            }

                // Clear the inputs
                this.addItemModel = new ItemModel();
            this.BindingContext = this.addItemModel;
            this.addItemModel.Name = string.Empty;
            this.addItemModel.Price = 0;
        }
    }
}