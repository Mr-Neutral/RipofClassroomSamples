using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chapter8
{
    public class CustomLabel : Label
    {
        public CustomLabel()
        {
            FontSize = 40;
            FontAttributes = FontAttributes.Bold;
            BackgroundColor = Color.Orange;
        }
    }
}
