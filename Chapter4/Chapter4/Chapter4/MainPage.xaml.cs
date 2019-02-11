using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = sender as Picker;

            DisplayAlert("Selected Value",
                         picker.SelectedItem.ToString(),
                         "Ok");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Butto Clicked",
                         thePicker.SelectedItem?.ToString(),
                         "Ok");
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DisplayAlert("Date Selected",
                         $"Old date was {e.OldDate.ToShortDateString()} new date is {e.NewDate.ToShortDateString()}",
                         "Ok");
        }
    }
}
