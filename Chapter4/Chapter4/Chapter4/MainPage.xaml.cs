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

            this.BackgroundColor = Color.FromHex(picker.SelectedItem.ToString());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Butto Clicked",
                         thePicker.SelectedItem?.ToString(),
                         "Ok");

            // Focus first name on button click
            var value = firstName.Focus();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DisplayAlert("Date Selected",
                         $"Old date was {e.OldDate.ToShortDateString()} new date is {e.NewDate.ToShortDateString()}",
                         "Ok");
        }

        private void TheTimePicker_PropertyChanged(object sender,
            System.ComponentModel.PropertyChangedEventArgs e)
        {
            // This method fires when any property changes
            // so we need to filter the property we listen to on just Time
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                DisplayAlert("Time Changed",
                             $"Time is {theTimePicker.Time}",
                             "Ok");
            }
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //DisplayAlert("Stepper Changed",
            //             $"Old value was {e.OldValue} new value is {e.NewValue}",
            //             "Ok");

            theStepperLabel.Text = e.NewValue.ToString();
        }

        private void TheSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            theSliderLabel.Text = e.NewValue.ToString();

            submitButton.Opacity = e.NewValue;
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Switch Toggled",
                         $"Value is {e.Value}",
                         "Ok");
        }
    }
}
