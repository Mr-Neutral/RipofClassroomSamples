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
    }
}
