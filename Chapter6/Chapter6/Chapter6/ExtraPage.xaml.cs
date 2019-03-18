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
	public partial class ExtraPage : ContentPage
	{
        private readonly int pageNumber;

        public ExtraPage (int pageNumber)
		{
			InitializeComponent ();
            this.pageNumber = pageNumber;
            pageLabel.Text = "Page " + pageNumber;
        }

        private void OnGoBackClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void GoForwardClick(object sender, EventArgs e)
        {
            Page extraPage = new ExtraPage(this.pageNumber + 1);
            Navigation.PushAsync(extraPage);
        }

        private void GoToBeginningClick(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}