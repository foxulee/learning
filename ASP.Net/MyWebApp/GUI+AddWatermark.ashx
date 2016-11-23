<%@ WebHandler Language="C#" Class="GUI_AddWatermark" %>

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web;

public class GUI_AddWatermark : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        //先创建一张图片，并且在图片上鞋子
        //1 创建画布
        using (Bitmap map = new Bitmap(300, 400))
        {
            //2 为画布创建画笔
            using (Graphics g = Graphics.FromImage(map))
            {
                g.Clear(Color.Gray);   //填充背景色
                g.DrawString("WaterMark", new Font("Arial", 14.0f, FontStyle.Bold), Brushes.Blue, new PointF(150, 200));//写字
                string fileName = Guid.NewGuid().ToString()+".jpg";
                //将画布保存成一张图片，并且指定图片的格式。
                map.Save(context.Request.MapPath("/ImageUp/" + fileName + ".jpg"), ImageFormat.Jpeg);
                context.Response.Write("<html><body><img src='/ImageUp/"+fileName+"'/></body></html>");

            }
        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}