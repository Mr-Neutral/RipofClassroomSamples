using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var mainPageViewModel = new MainPageViewModel
            {
                Items = new List<ItemModel>
                {
                    new ItemModel(1, "Pizza", 5),
                    new ItemModel(2, "Burger", 3)
                }
            };

            this.BindingContext = mainPageViewModel;
        }
    }
}
