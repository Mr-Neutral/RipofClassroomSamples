using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(Chapter9.UWP.UwpHelloWorld))]
namespace Chapter9.UWP
{
    public class UwpHelloWorld : IHelloWorld
    {
        public string HelloWorld()
        {


            return "Hello from UWP!";
        }
    }
}
