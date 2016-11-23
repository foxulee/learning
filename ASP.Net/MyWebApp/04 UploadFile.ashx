<%@ WebHandler Language="C#" Class="_04_UploadFile" %>

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web;

public class _04_UploadFile : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";

        //.NET 允许的上传文件的大小不超过4MB 
        //PHP 2MB

        //接收文件
        HttpPostedFile file = context.Request.Files["fileup"];
        if (file != null)
        {
            //判断文件的类型
            string fileName = Path.GetFileName(file.FileName);    //FileName方法获取文件名称.Path.GetFileName方法只返回文件名与扩展名
            string fileExt = Path.GetExtension(fileName);
            List<string> allowTypeList = new List<string>() { ".jpg", ".bmp", ".JPG" };
            if (allowTypeList.Contains(fileExt))
            {
                //保存到指定的文件夹下面
                //问题1 文件重名问题
                //问题2 上传图片多不变管理降低性能。所以将上传的文件存储到不同的文件夹下。
                //file.SaveAs(context.Request.MapPath("/ImageUp/" + fileName));

                //防止重名 guid
                string newFileName = Guid.NewGuid().ToString();
                //放不同文件夹
                string dir = "/ImageUp/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/";
                if (!Directory.Exists(context.Request.MapPath(dir)))
                {
                    Directory.CreateDirectory(context.Request.MapPath(dir));
                }
                string fullDir = dir + newFileName + fileExt;  //构建完整的路径
                file.SaveAs(context.Request.MapPath(fullDir));


                //给上传成功的图片添加水印
                //根据上传成功的图片创建一个Image
                //Image img = Image.FromStream(file.InputStream); //从文件流获取
                using (Image img = Image.FromFile(context.Request.MapPath(fullDir)))  //FromFile从文件物理路径获取
                {
                    //1 创建一个画布（画布的高度与宽度与图片的高度宽度一致）
                    using (Bitmap map = new Bitmap(img.Width,img.Height))
                    {
                        //2 为画布创建一个画笔
                        using (Graphics g = Graphics.FromImage(map))
                        {
                            //3 将上传成功的图片画到画布上
                            g.DrawImage(img,0,0, img.Width, img.Height);
                            //4 在画布上鞋子 
                            g.DrawString("WaterMark", new Font("Arial", 14.0f, FontStyle.Bold), Brushes.Blue, new PointF(15, 15));

                            //5 将画布保存
                            string watermarkedImageName = Guid.NewGuid().ToString() + ".jpg";
                            map.Save(context.Request.MapPath("/ImageUp/"+watermarkedImageName),ImageFormat.Jpeg);
                        }
                    }
                }

                //最后应该将上传成功的图片的路径存储到数据库中。

                context.Response.Write("上传成功");
            }
            else
            {
                context.Response.Write("文件类型错误");
            }
        }
        else
        {
            context.Response.Write("请选择上传的文件");
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