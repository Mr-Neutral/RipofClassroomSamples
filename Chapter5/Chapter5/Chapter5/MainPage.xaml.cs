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

            List<string> items = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                items.Add(i.ToString());
            }

            simpleListView.ItemsSource = items;
        }

        private void SimpleListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Item Tapped",
                        $"{e.Item} was tapped",
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
    }
}
