using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter6
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetails : ContentPage
	{
		public ItemDetails (MenuItem item)
		{
			InitializeComponent ();

            IdLabel.Text = item.Id.ToString();
            ItemLabel.Text = item.Item;
            PriceLabel.Text = item.Price.ToString("C");
		}
	}
}