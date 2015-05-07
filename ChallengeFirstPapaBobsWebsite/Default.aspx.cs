using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double total;

            if(babyRadioButton.Checked)
            {
                total = 10;
            }
            else if(mamaRadioButton.Checked)
            {
                total = 13;
            }
            else if(papaRadioButton.Checked)
            {
                total = 16;
            }
            else
                total = 0.00;

            if(deepRadioButton.Checked)
                total += 2;

            if(pepperoniCheckBox.Checked)
                total += 1.50;

            if(onionsCheckBox.Checked)
                total += 0.75;

            if(greenPeppersCheckBox.Checked)
                total += 0.50;

            if(redPeppersCheckBox.Checked)
                total += 0.75;

            if(anchoviesCheckBox.Checked)
                total += 2;

            if((pepperoniCheckBox.Checked && greenPeppersCheckBox.Checked && anchoviesCheckBox.Checked) || (pepperoniCheckBox.Checked && redPeppersCheckBox.Checked && onionsCheckBox.Checked))
                total -= 2;

            totalLabel.Text = "$" + total.ToString();
        }
    }
}