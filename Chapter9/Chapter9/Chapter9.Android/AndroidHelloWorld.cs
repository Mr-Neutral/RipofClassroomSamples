using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

[assembly: Dependency(typeof(Chapter9.Droid.AndroidHelloWorld))]
namespace Chapter9.Droid
{
    public class AndroidHelloWorld : IHelloWorld
    {
        public string HelloWorld()
        {
            return "Hello from Android";
        }
    }
}