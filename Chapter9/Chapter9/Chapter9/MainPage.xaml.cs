using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter9
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            IHelloWorld helloWorld = DependencyService.Get<IHelloWorld>();
            helloLabel.Text = helloWorld.HelloWorld();
        }
    }
}
