using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChatTamplate
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<User> Users = new List<User> {
            new User {Name="Ninkita",ImageUser="~/Content/Cat.jpg" },
            new User {Name="Piter", ImageUser= "~/Content/Cat.jpg" } };

        protected void Page_Load(object sender, EventArgs e)
        {
            ListUsers.DataSource = Users;
            ListUsers.DataBind();
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string ImageUser { get; set; }
    }
}