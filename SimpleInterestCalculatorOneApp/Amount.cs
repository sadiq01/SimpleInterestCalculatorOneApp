using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestCalculatorOneApp
{
    class Amount
    {
        public double principleAmount, annualInterestRate, timePeriod;
        public double totalAmount;
    public double GetTotalAmount()
    {
        return principleAmount*(Math.Pow((1 + annualInterestRate),timePeriod));
    }
    }
    
}
