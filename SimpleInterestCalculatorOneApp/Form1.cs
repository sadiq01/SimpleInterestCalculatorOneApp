using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterestCalculatorOneApp
{
    public partial class SimpleInterestCalculatorUi : Form
    {
        public SimpleInterestCalculatorUi()
        {
            InitializeComponent();
        }
        Amount bAmount=new Amount();
        private void calculateButton_Click(object sender, EventArgs e)
        {
            bAmount.principleAmount = Convert.ToDouble(principalAmountTextBox.Text);
            bAmount.annualInterestRate = (Convert.ToDouble(annualInterestRateTextBox.Text))/100;
            bAmount.timePeriod = Convert.ToDouble(timePeriodTextBox.Text);
            bAmount.totalAmount = bAmount.GetTotalAmount();
            totalAmountTextBox.Text = bAmount.totalAmount.ToString();
        }
    }
}
