<%@ WebHandler Language="C#" Class="_05_缩略图" %>

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web;
using Image = System.Drawing.Image;

public class _05_缩略图 : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";

        //1 手动指定
        //using (Image img = Image.FromFile(context.Request.MapPath("ImageUp/05d4d99f-ff46-4df4-a9e6-fba91a35dcf6.jpg")))
        //{
        //    //直接指定画布的大小
        //    using (Bitmap map = new Bitmap(img, 50, 50))
        //    {
        //            Graphics g = Graphics.FromImage(map);
        //            g.DrawImage(img, 0,0,map.Width,map.Height);
        //        string name = "05d4d99f-ff46-4df4-a9e6-fba91a35dcf6-small.jpg";
        //            map.Save(context.Request.MapPath("/ImageUp/"+name),ImageFormat.Jpeg);
        //            context.Response.Write("<html><body> <img src='/ImageUp/"+name+"' /></body></html>");
        //    }
        //}

            //2 运用现成的class
            string name = "05d4d99f-ff46-4df4-a9e6-fba91a35dcf6-thumb.jpg";
            ImageClass.MakeThumbnail(context.Request.MapPath("ImageUp/05d4d99f-ff46-4df4-a9e6-fba91a35dcf6.jpg"),context.Request.MapPath("/ImageUp/"+name),50,50,"W");
            context.Response.Write("<html><body> <img src='/ImageUp/"+name+"' /></body></html>");


    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}