using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UploadsFIle
{
    public partial class ThumbailsViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(Request.QueryString["X"])) ||
                (String.IsNullOrEmpty(Request.QueryString["Y"])) ||
                (String.IsNullOrEmpty(Request.QueryString["FilePath"])))
            {
                // Часть данных отсутствует, поэтому ничего не выводить на экран. 
                // Другие возможные варианты действий - выбор подходящих значений по умолчанию 
                // или возврат изображения со статическим текстом сообщения об ошибке
            }
            else
            {
                int x = Int32.Parse(Request.QueryString["X"]);
                int y = Int32.Parse(Request.QueryString["Y"]);
                string file = Server.UrlDecode(Request.QueryString["FilePath"]);

                // Создать хранящееся в памяти растровое изображение,
                // где будет выполняться рисование
                using (Bitmap image = new Bitmap(x, y))
                {
                    using (Graphics graphic = Graphics.FromImage(image))
                    {
                        // Загрузить данные из файла
                        System.Drawing.Image thumbnail =
                            System.Drawing.Image.FromFile(file);

                        // Нарисовать эскиз
                        graphic.DrawImage(thumbnail, 0, 0, x, y);

                        // Сохранить изображение
                        image.Save(Response.OutputStream, ImageFormat.Jpeg);
                    }
                }
            }
        }
    }
}