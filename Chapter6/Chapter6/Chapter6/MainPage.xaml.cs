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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Page secondPage = new SecondPage();
            await Navigation.PushAsync(secondPage);

            // alternate one liner
            //Navigation.PushAsync(new SecondPage());
        }

        private async void AskQuestionClicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Question",
                                             "Answer with yes / no",
                                             "Yes",
                                             "No");

            if (result)
            {
                // They clicked Yes
            }
            else
            {
                // They clicked no
            }
        }

        private async void ChooseOptionClicked(object sender, EventArgs e)
        {
            string result = await DisplayActionSheet("Choose an Option",
                                                     "Cancel",
                                                     null, //"Destruction",
                                                     "Option 1",
                                                     "Option 2",
                                                     "Option 3");

            await DisplayAlert("You Chose", result, "Ok");
        }
    }
}
