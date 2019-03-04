using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoanPayoff
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<MonthlyPayment> paymentScheduleList = new ObservableCollection<MonthlyPayment>();

        public MainPage()
        {
            InitializeComponent();
            PaymentSchedule.ItemsSource = paymentScheduleList;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Get inputs from the UI store as decimal values
            if (!double.TryParse(Principle.Text, out double balance) ||
                !double.TryParse(InterestRate.Text, out double interestRate) ||
                !int.TryParse(Months.Text, out int months))
            {
                this.DisplayAlert("Invalid Input",
                    "Please enter numeric values",
                    "Ok");

                return;
            }
            
            double convertedRate = interestRate / 100 / 12;
            double payment = balance *
                            (convertedRate * Math.Pow((1 + convertedRate), months)) /
                            (Math.Pow(1 + convertedRate, months) - 1);

            MonthlyPayment.Text = payment.ToString("C");

            this.paymentScheduleList.Clear();

            double totalInterest = 0;

            for (int month = 1; month <= months; month++)
            {
                double monthlyInterest = convertedRate * balance;
                totalInterest += monthlyInterest;

                double total = monthlyInterest + balance;
                balance = total - payment;
                
                MonthlyPayment paymentDetails = new MonthlyPayment
                {
                    Month = month,
                    Balance = balance.ToString("c"),
                    Interest = monthlyInterest.ToString("c")
                };

                this.paymentScheduleList.Add(paymentDetails);
            }

            TotalInterest.Text = totalInterest.ToString("c");
        }
    }
}
