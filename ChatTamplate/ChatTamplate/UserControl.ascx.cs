using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChatTamplate
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        public string NameU { get; set; } 

        public string ImgU { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (NameU == null)
            {
                NameUser.Text = "User not found";
                ImgUser.ImageUrl = "~/Content/Cat.jpg";
            }
            else {
                NameUser.Text = NameU;
                ImgUser.ImageUrl = ImgU;
            }
            NameUser.CssClass = "nameU";
        }
    }
}