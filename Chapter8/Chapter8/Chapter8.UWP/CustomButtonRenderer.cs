using Chapter8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomButton),
                          typeof(Chapter8.UWP.CustomButtonRenderer))]

namespace Chapter8.UWP
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var button = Control as Windows.UI.Xaml.Controls.Button;
                button.Background = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }
    }
}
