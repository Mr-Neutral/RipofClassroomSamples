using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoanPayoff
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Get inputs from the UI store as decimal values
            double balance = double.Parse(Principle.Text);
            double interestRate = double.Parse(InterestRate.Text);
            int months = int.Parse(Months.Text);
            
            double convertedRate = interestRate / 100 / 12;
            double payment = balance *
                            (convertedRate * Math.Pow((1 + convertedRate), months)) /
                            (Math.Pow(1 + convertedRate, months) - 1);

            MonthlyPayment.Text = payment.ToString("C");
        }
    }
}
