using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UploadsFIle
{
    public partial class ViewPhotos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_Init(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\Visual Studio 2015\Projects\ASP\Lab\UploadsFIle\UploadsFIle\Data");
            gridThumbs.DataSource = dir.GetFiles();

            gridThumbs.DataBind();
        }
        protected string GetImageUrl(object path)
        {
            return "ThumbailsViewer.aspx?x=150&y=150&FilePath=" + Server.UrlEncode((string)path);
        }
    }
}