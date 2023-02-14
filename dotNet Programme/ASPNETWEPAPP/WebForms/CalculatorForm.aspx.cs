using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPwebApps
{
    public partial class CalculatorForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            var val1 = double.Parse(txtfirstNo.Text);
            var val2 = double.Parse(txtSecondNo.Text);
            var operation = dpList.SelectedValue;
            var result = getReult(val1, val2, operation);
            lblDisplay.Text = "The Result: " + result;
        }

        private object getReult(double val1, double val2, string operation)
        {
            switch (operation)
            {
                case "Add":return val1 + val2;break;
                case "Subtract": return val1 - val2; break;
                case "Multiply": return val1 * val2; break;
                case "Divide": return val1 / val2; break;
                default:
                    break;
            }
            return 0;
        }
    }
}