using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Turn off nav bar
            //NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Page secondPage = new SecondPage();
            Navigation.PushAsync(secondPage);

            // alternate one liner
            //Navigation.PushAsync(new SecondPage());
        }
    }
}
