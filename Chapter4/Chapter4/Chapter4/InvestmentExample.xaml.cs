using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InvestmentExample : ContentPage
    {
        public InvestmentExample()
        {
            InitializeComponent();
        }


        private double CalculateTotal(double initialInvestment,
                              double monthlyInvestment,
                              double numberOfYears,
                              int compoundsPerYear,
                              double interestRate)
        {
            var periodicInvestment = monthlyInvestment * 12 / compoundsPerYear;
            interestRate /= 100;

            var innerCalculation = Math.Pow(1 + interestRate / compoundsPerYear, compoundsPerYear * numberOfYears);
            var compoundInterestForPrinciple = initialInvestment * innerCalculation;
            var futureValueOfSeries = periodicInvestment * (innerCalculation - 1) * (compoundsPerYear / interestRate);
            return compoundInterestForPrinciple + futureValueOfSeries;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int compoundValue;

            switch (compounds.SelectedItem)
            {
                case "Daily":
                    compoundValue = 365;
                    break;
                case "Monthly":
                    compoundValue = 12;
                    break;
                default:
                case "Yearly":
                    compoundValue = 1;
                    break;
            }

            double result = CalculateTotal(double.Parse(entryInitial.Text),
                                           monthlyInvestment.Value,
                                           numberOfYears.Value,
                                           compoundValue,
                                           interestRate.Value);

            total.Text = result.ToString("C");
        }

        private void MonthlyInvestment_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            monthlyInvestmentValue.Text = monthlyInvestment.Value.ToString("c");
        }

        private void NumberOfYears_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            numberOfYearsValue.Text = numberOfYears.Value.ToString();
        }

        private void InterestRate_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            interestRateValue.Text = interestRate.Value.ToString();
        }
    }
}