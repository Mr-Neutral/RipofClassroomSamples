using System;
using System.Collections.Generic;
using System.Text;

namespace LoanPayoff
{
    public class MonthlyPayment
    {
        public int Month { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }
    }
}
