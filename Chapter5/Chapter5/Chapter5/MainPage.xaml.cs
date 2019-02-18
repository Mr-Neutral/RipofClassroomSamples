using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Person> people = new List<Person>();

            var hank = new Person();
            hank.FirstName = "Hank";
            hank.LastName = "Hill";
            hank.Picture = new Uri("https://www.shareicon.net/data/128x128/2015/11/12/163142_hill_128x128.png");
            people.Add(hank);

            var peggy = new Person();
            peggy.FirstName = "Peggy";
            peggy.LastName = "Hill";
            peggy.Picture = new Uri("https://www.shareicon.net/data/128x128/2015/11/12/163145_hill_128x128.png");
            people.Add(peggy);

            simpleListView.ItemsSource = people;
        }

        private void SimpleListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Person tapped = (Person)e.Item;

            DisplayAlert("Item Tapped",
                        $"{tapped.LastName}, {tapped.FirstName} was tapped",
                        "Ok");
        }

        private void SimpleListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string selectedItem = "NULL";

            if (e.SelectedItem != null)
            {
                selectedItem = e.SelectedItem.ToString();
            }

            DisplayAlert("Item Selected",
                        $"{selectedItem} was selected",
                        "Ok");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            simpleListView.SelectedItem = null;
        }

        private void OnListViewRowButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var person = (Person)button.CommandParameter;

            DisplayAlert("Button Clicked",
                        $"{person.LastName}, {person.FirstName} button was clicked",
                        "Ok");
        }
    }
}
