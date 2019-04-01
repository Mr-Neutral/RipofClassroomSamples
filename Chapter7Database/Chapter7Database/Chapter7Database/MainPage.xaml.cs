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

            //this.person = new PersonModel();

            this.person = App.Database.Get<PersonModel>(1);

            this.BindingContext = this.person;
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            App.Database.Insert(person);

            this.person = new PersonModel();
            this.BindingContext = this.person;
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            App.Database.Delete(person);
        }
    }
}
