using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chapter8
{
    public class CustomButton : Button
    {
        private int _counter = 0;

        public CustomButton()
        {
            this.Clicked += this.OnButtonClicked;
            this.Text = "0";
        }

        public int Counter
        {
            get => _counter;
            set
            {
                this._counter = value;
                this.Text = this._counter.ToString();
            }
        }

        public void OnButtonClicked(object sender, EventArgs e)
        {
            this.Counter++;
        }
    }
}
