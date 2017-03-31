using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SumTwoTextBox
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                x1.Text = "0";
                x2.Text = "0";
            }
        }

        protected void SumButton_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(x1.Text);
            int second = Convert.ToInt32(x2.Text);
            ResultSum.Text = Convert.ToString(first + second);
        }
    }
}