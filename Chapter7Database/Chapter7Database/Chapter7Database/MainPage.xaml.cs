using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter7Database
{
    public partial class MainPage : ContentPage
    {
        private PersonModel person;

        public MainPage()
        {
            InitializeComponent();

            this.person = new PersonModel();
            this.BindingContext = this.person;
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {

        }
    }
}
