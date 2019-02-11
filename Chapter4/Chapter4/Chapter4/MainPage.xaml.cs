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
            DisplayAlert("Selected Value",
                         thePicker.SelectedItem?.ToString(),
                         "Ok");
        }
    }
}
