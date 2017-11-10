using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClassLibraryDAL.GraphicsProcess
{
    /// <summary>
    /// http://blog.csdn.net/suncherrydream/article/details/17585201 C#高效绘图（转）
    /// </summary>
    public class GraphicsOS
    {
        public void DrawTable(PictureBox picBatchImage)
        {
            Bitmap bmp = new Bitmap(picBatchImage.Image, picBatchImage.Width, picBatchImage.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Pen pen = new Pen(Color.Black);
            //竖
            g.DrawLine(pen, 10, 10, 10, 390);
            g.DrawLine(pen, 90, 10, 90, 390);
            g.DrawLine(pen, 170, 10, 170, 390);
            g.DrawLine(pen, 250, 10, 250, 390);
            g.DrawLine(pen, 330, 10, 330, 390);
            g.DrawLine(pen, 410, 10, 410, 390);

            //横
            g.DrawLine(pen, 10, 10, 410, 10);
            g.DrawLine(pen, 10, 90, 410, 90);
            g.DrawLine(pen, 10, 150, 410, 150);
            g.DrawLine(pen, 10, 210, 410, 210);
            g.DrawLine(pen, 10, 270, 410, 270);
            g.DrawLine(pen, 10, 330, 410, 330);
            g.DrawLine(pen, 10, 390, 410, 390);

            g.DrawString("尺寸", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 45);
            g.DrawString("衣长", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 45);
            g.DrawString("袖长", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 45);
            g.DrawString("胸围", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 45);
            g.DrawString("肩宽", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 45);

            g.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 110);
            g.DrawString("51", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 110);
            g.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 110);
            g.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 110);
            g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 110);

            g.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 170);
            g.DrawString("59", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 170);
            g.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 170);
            g.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 170);
            g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 170);

            g.DrawString("L", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 230);
            g.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 230);
            g.DrawString("48", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 230);
            g.DrawString("108", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 230);
            g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 230);

            g.DrawString("XL", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 290);
            g.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 290);
            g.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 290);
            g.DrawString("112", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 290);
            g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 290);

            g.DrawString("2XL", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 350);
            g.DrawString("65", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 350);
            g.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 350);
            g.DrawString("116", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 350);
            g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 350);

            bmp.Save(@"E:\Picture\SAVE.Jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            bmp.Dispose();

            Application.DoEvents();

            //Graphics graphics = e.Graphics;
            ////竖
            //graphics.DrawLine(pen, 10, 10, 10, 390);
            //graphics.DrawLine(pen, 90, 10, 90, 390);
            //graphics.DrawLine(pen, 170, 10, 170, 390);
            //graphics.DrawLine(pen, 250, 10, 250, 390);
            //graphics.DrawLine(pen, 330, 10, 330, 390);
            //graphics.DrawLine(pen, 410, 10, 410, 390);

            ////横
            //graphics.DrawLine(pen, 10, 10, 410, 10);
            //graphics.DrawLine(pen, 10, 90, 410, 90);
            //graphics.DrawLine(pen, 10, 150, 410, 150);
            //graphics.DrawLine(pen, 10, 210, 410, 210);
            //graphics.DrawLine(pen, 10, 270, 410, 270);
            //graphics.DrawLine(pen, 10, 330, 410, 330);
            //graphics.DrawLine(pen, 10, 390, 410, 390);

            //graphics.DrawString("尺寸", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 45);
            //graphics.DrawString("衣长", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 45);
            //graphics.DrawString("袖长", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 45);
            //graphics.DrawString("胸围", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 45);
            //graphics.DrawString("肩宽", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 45);

            //graphics.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 110);
            //graphics.DrawString("51", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 110);
            //graphics.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 110);
            //graphics.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 110);
            //graphics.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 110);

            //graphics.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 170);
            //graphics.DrawString("59", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 170);
            //graphics.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 170);
            //graphics.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 170);
            //graphics.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 170);

            //graphics.DrawString("L", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 230);
            //graphics.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 230);
            //graphics.DrawString("48", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 230);
            //graphics.DrawString("108", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 230);
            //graphics.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 230);

            //graphics.DrawString("XL", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 290);
            //graphics.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 290);
            //graphics.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 290);
            //graphics.DrawString("112", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 290);
            //graphics.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 290);

            //graphics.DrawString("2XL", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 350);
            //graphics.DrawString("65", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 350);
            //graphics.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 350);
            //graphics.DrawString("116", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 350);
            //graphics.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 350);
        }


        public void DrawTable02()
        {
            //尺码表
            //g.FillRectangle(new SolidBrush(Color.Gold), 10, 80, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.Gold), 10, 134, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.Gold), 10, 188, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.Gold), 10, 242, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.Gold), 10, 296, 730, 50);

            //g.DrawString("尺寸", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 62, 90);
            //g.DrawString("衣长", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 190, 90);
            //g.DrawString("袖长", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 330, 90);
            //g.DrawString("胸围", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 480, 90);
            //g.DrawString("肩宽", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 610, 90);

            //g.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 110);
            //g.DrawString("51", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 110);
            //g.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 110);
            //g.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 110);
            //g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 110);

            //g.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 170);
            //g.DrawString("59", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 170);
            //g.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 170);
            //g.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 170);
            //g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 170);

            //g.DrawString("L", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 230);
            //g.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 230);
            //g.DrawString("48", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 230);
            //g.DrawString("108", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 230);
            //g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 230);

            //g.DrawString("XL", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 290);
            //g.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 290);
            //g.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 290);
            //g.DrawString("112", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 290);
            //g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 290);

            //g.DrawString("2XL", new Font("黑体", 15), new SolidBrush(Color.Black), 28, 350);
            //g.DrawString("65", new Font("黑体", 15), new SolidBrush(Color.Black), 107, 350);
            //g.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.Black), 187, 350);
            //g.DrawString("116", new Font("黑体", 15), new SolidBrush(Color.Black), 267, 350);
            //g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.Black), 347, 350);
        }

        public void DrawTableForMinimalist(Graphics ePen ,PictureBox pictureBox)
        {
            Graphics gc = Graphics.FromImage(pictureBox.Image);
            gc.Clear(Color.White);
            pictureBox.Width = 750;
            pictureBox.Height = 880;

            Bitmap bmp = new Bitmap(pictureBox.Image, pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.DrawString("SIZE X 尺码表", new Font("微软雅黑", 20), new SolidBrush(Color.Black), 276, 22);
            //尺码表
            g.FillRectangle(new SolidBrush(Color.FromArgb(139, 139, 139)), 10, 80, 730, 50);
            g.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 126, 730, 50);
            g.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 176, 730, 50);
            g.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 226, 730, 50);
            g.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 276, 730, 50);
            g.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 326, 730, 50);

            g.DrawString("尺寸", new Font("微软雅黑", 16), new SolidBrush(Color.White), 68, 88);
            g.DrawString("衣长", new Font("微软雅黑", 16), new SolidBrush(Color.White), 198, 88);
            g.DrawString("袖长", new Font("微软雅黑", 16), new SolidBrush(Color.White), 344, 88);
            g.DrawString("胸围", new Font("微软雅黑", 16), new SolidBrush(Color.White), 490, 88);
            g.DrawString("肩宽", new Font("微软雅黑", 16), new SolidBrush(Color.White), 630, 88);

            g.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 140);
            g.DrawString("51", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 140);
            g.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 140);
            g.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 140);
            g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 140);

            g.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 190);
            g.DrawString("59", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 190);
            g.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 190);
            g.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 190);
            g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 190);

            g.DrawString("L", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 240);
            g.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 240);
            g.DrawString("48", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 240);
            g.DrawString("108", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 240);
            g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 240);

            g.DrawString("XL", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 290);
            g.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 290);
            g.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 290);
            g.DrawString("112", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 290);
            g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 290);

            g.DrawString("2XL", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 340);
            g.DrawString("65", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 340);
            g.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 340);
            g.DrawString("116", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 340);
            g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 340);

            g.DrawString("注意：均码是根据身高165CM,体重100斤来算的哟，只要身高误差不超过20CM,", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 80, 390);
            g.DrawString("体重误差不超过20斤，都是可以穿的哟~~~", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 132, 410);
            g.DrawString("温馨提示：由于手工测绘不通，1-2CM测量误差属于正常范围。", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 80, 432);

            g.DrawString("REFERENCE X 试穿参考", new Font("微软雅黑", 20), new SolidBrush(Color.Black), 216, 480);

            g.FillRectangle(new SolidBrush(Color.FromArgb(139, 139, 139)), 10, 540, 730, 50);
            g.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 586, 730, 50);
            g.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 636, 730, 50);
            g.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 686, 730, 50);
            g.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 736, 730, 50);
            g.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 786, 730, 50);

            g.DrawString("Model", new Font("微软雅黑", 16), new SolidBrush(Color.White), 48, 548);
            g.DrawString("身高/体重", new Font("微软雅黑", 16), new SolidBrush(Color.White), 170, 548);
            g.DrawString("三围", new Font("微软雅黑", 16), new SolidBrush(Color.White), 334, 548);
            g.DrawString("试穿尺码", new Font("微软雅黑", 16), new SolidBrush(Color.White), 450, 548);
            g.DrawString("试穿体验", new Font("微软雅黑", 16), new SolidBrush(Color.White), 600, 548);

            g.DrawString("Ada", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 598);
            g.DrawString("157/44", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 598);
            g.DrawString("81/68/86", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 598);
            g.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 598);
            g.DrawString("穿着舒适", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 598);

            g.DrawString("Lena", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 648);
            g.DrawString("159/49", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 648);
            g.DrawString("83/66/86", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 648);
            g.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 648);
            g.DrawString("刚刚好哟", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 648);

            g.DrawString("Alice", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 698);
            g.DrawString("162/53", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 698);
            g.DrawString("88/70/90", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 698);
            g.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 698);
            g.DrawString("穿着舒适", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 698);

            g.DrawString("Finn", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 748);
            g.DrawString("165/59", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 748);
            g.DrawString("91/76/98", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 748);
            g.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 748);
            g.DrawString("刚刚好哟", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 748);

            g.DrawString("Erica", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 798);
            g.DrawString("175/56", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 798);
            g.DrawString("87/69/94", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 798);
            g.DrawString("L", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 798);
            g.DrawString("穿着舒适", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 798);

            bmp.Save(@"E:\Picture\SAVE.Jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            bmp.Dispose();

            //Application.DoEvents();

            Graphics eg = ePen;
            eg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            eg.DrawString("SIZE X 尺码表", new Font("微软雅黑", 20), new SolidBrush(Color.Black), 276, 22);

            //尺码表
            eg.FillRectangle(new SolidBrush(Color.FromArgb(139, 139, 139)), 10, 80, 730, 50);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 126, 730, 50);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 176, 730, 50);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 226, 730, 50);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 276, 730, 50);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 326, 730, 50);

            eg.DrawString("尺寸", new Font("微软雅黑", 16), new SolidBrush(Color.White), 68, 88);
            eg.DrawString("衣长", new Font("微软雅黑", 16), new SolidBrush(Color.White), 198, 88);
            eg.DrawString("袖长", new Font("微软雅黑", 16), new SolidBrush(Color.White), 344, 88);
            eg.DrawString("胸围", new Font("微软雅黑", 16), new SolidBrush(Color.White), 490, 88);
            eg.DrawString("肩宽", new Font("微软雅黑", 16), new SolidBrush(Color.White), 630, 88);

            eg.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 140);
            eg.DrawString("51", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 140);
            eg.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 140);
            eg.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 140);
            eg.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 140);

            eg.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 190);
            eg.DrawString("59", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 190);
            eg.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 190);
            eg.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 190);
            eg.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 190);

            eg.DrawString("L", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 240);
            eg.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 240);
            eg.DrawString("48", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 240);
            eg.DrawString("108", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 240);
            eg.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 240);

            eg.DrawString("XL", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 290);
            eg.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 290);
            eg.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 290);
            eg.DrawString("112", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 290);
            eg.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 290);

            eg.DrawString("2XL", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 340);
            eg.DrawString("65", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 340);
            eg.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 340);
            eg.DrawString("116", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 340);
            eg.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 340);

            eg.DrawString("注意：均码是根据身高165CM,体重100斤来算的哟，只要身高误差不超过20CM,", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 80, 390);
            eg.DrawString("体重误差不超过20斤，都是可以穿的哟~~~", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 132, 410);
            eg.DrawString("温馨提示：由于手工测绘不通，1-2CM测量误差属于正常范围。", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 80, 432);

            eg.DrawString("REFERENCE X 试穿参考", new Font("微软雅黑", 20), new SolidBrush(Color.Black), 216, 480);

            eg.FillRectangle(new SolidBrush(Color.FromArgb(139, 139, 139)), 10, 540, 730, 50);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 586, 730, 50);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 636, 730, 50);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 686, 730, 50);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 736, 730, 50);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 786, 730, 50);

            eg.DrawString("Model", new Font("微软雅黑", 16), new SolidBrush(Color.White), 48, 548);
            eg.DrawString("身高/体重", new Font("微软雅黑", 16), new SolidBrush(Color.White), 170, 548);
            eg.DrawString("三围", new Font("微软雅黑", 16), new SolidBrush(Color.White), 334, 548);
            eg.DrawString("试穿尺码", new Font("微软雅黑", 16), new SolidBrush(Color.White), 450, 548);
            eg.DrawString("试穿体验", new Font("微软雅黑", 16), new SolidBrush(Color.White), 600, 548);

            eg.DrawString("Ada", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 598);
            eg.DrawString("157/44", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 598);
            eg.DrawString("81/68/86", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 598);
            eg.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 598);
            eg.DrawString("穿着舒适", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 598);

            eg.DrawString("Lena", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 648);
            eg.DrawString("159/49", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 648);
            eg.DrawString("83/66/86", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 648);
            eg.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 648);
            eg.DrawString("刚刚好哟", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 648);

            eg.DrawString("Alice", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 698);
            eg.DrawString("162/53", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 698);
            eg.DrawString("88/70/90", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 698);
            eg.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 698);
            eg.DrawString("穿着舒适", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 698);

            eg.DrawString("Finn", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 748);
            eg.DrawString("165/59", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 748);
            eg.DrawString("91/76/98", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 748);
            eg.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 748);
            eg.DrawString("刚刚好哟", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 748);

            eg.DrawString("Erica", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 798);
            eg.DrawString("175/56", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 798);
            eg.DrawString("87/69/94", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 798);
            eg.DrawString("L", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 798);
            eg.DrawString("穿着舒适", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 798);
        }

        public void DrawTableForClear(PictureBox pictureBox,Graphics ePen)
        {
            Graphics gc = Graphics.FromImage(pictureBox.Image);
            gc.Clear(Color.White);
            pictureBox.Width = 750;
            pictureBox.Height = 880;

            Graphics eg = ePen;
            eg.Clear(Color.White);
        }
    }
}
