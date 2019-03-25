using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditPage : ContentPage
	{
        private readonly ItemModel item;
        private readonly ItemModel editPageValue;

        public EditPage (ItemModel item)
		{
			InitializeComponent ();

            this.editPageValue = new ItemModel(item.Id, item.Name, item.Price);
            this.BindingContext = this.editPageValue;
            this.item = item;
        }

        private async void OnEditItem(object sender, EventArgs e)
        {
            this.item.Name = this.editPageValue.Name;
            this.item.Price = this.editPageValue.Price;
            await Navigation.PopAsync();
        }
    }
}