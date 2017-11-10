using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryDAL.GraphicsProcess;

namespace WebsiteScrapeForm
{
    /// <summary>
    /// http://bbs.csdn.net/topics/390981184 picturebox画图， 已经实现，求如何保存图片
    /// http://blog.csdn.net/suncherrydream/article/details/17585201 C#高效绘图（转）
    /// http://bbs.csdn.net/topics/391872698 C#Winfom如何获取控件的滚动条位置并判断是否到达底部 [问题点数：45分]
    /// </summary>
    public partial class CustomProcessingBatchPictureForm : Form
    {
        private Point pnlSizeSetOffset;
        private GraphicsOS go;
        [DllImport("user32.dll", EntryPoint = "GetScrollPos")]
        public static extern int GetScrollPos(IntPtr hwnd,int nBar);
        public CustomProcessingBatchPictureForm()
        {
            InitializeComponent();
            this.pnlSizeSet.Hide();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            go = new GraphicsOS();
        }
        private void pnlSizeSet_MouseDown(object sender, MouseEventArgs e)
        {
            pnlSizeSetOffset.X = e.X;
            pnlSizeSetOffset.Y = e.Y;
        }

        private void pnlSizeSet_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int left = pnlSizeSet.Left + e.X - pnlSizeSetOffset.X;
                int top = pnlSizeSet.Top + e.Y - pnlSizeSetOffset.Y;
                pnlSizeSet.Location = new Point(left, top);
            }
        }

        private void CustomProcessingBatchPictureForm_Load(object sender, EventArgs e)
        {

        }

        private void picBatchImage_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void picBatchImage_Resize(object sender, EventArgs e)
        {

        }

        private void btnProcessBatch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// http://bbs.csdn.net/topics/340209292
        /// https://zhidao.baidu.com/question/478452338.html c#如何在类中调用picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSizeSet_Click(object sender, EventArgs e)
        {
            this.pnlSizeSet.Show();
            this.picBatchImage.Paint += picBatchImage_Paint;
        }

        private void picBatchImage_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// PictureBox的Modified模式必须设置为true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBatchImage_Paint(object sender, PaintEventArgs e)
        {

            //Graphics g = e.Graphics;
            //g.DrawRectangle(new Pen(Color.Black),10,10,740,30);
            //int totals = 5;
            //int margin = 4;
            //int yAxies = 100;
            //int height = 50;
            //for (int i = totals; i > 0; i--)
            //{
            //    int compute = i * height;
            //    g.FillRectangle(new SolidBrush(Color.Gold), 10, yAxies + compute, 730, height);
            //}

            //Bitmap bmp = new Bitmap(picBatchImage.Image, picBatchImage.Width, picBatchImage.Height);
            //Graphics g = Graphics.FromImage(bmp);
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //g.DrawString("SIZE X 尺码表", new Font("微软雅黑", 20), new SolidBrush(Color.Black), 276, 22);
            ////尺码表
            //g.FillRectangle(new SolidBrush(Color.FromArgb(139, 139, 139)), 10, 80, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 126, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 176, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 226, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 276, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 326, 730, 50);

            //g.DrawString("尺寸", new Font("微软雅黑", 16), new SolidBrush(Color.White), 68, 88);
            //g.DrawString("衣长", new Font("微软雅黑", 16), new SolidBrush(Color.White), 198, 88);
            //g.DrawString("袖长", new Font("微软雅黑", 16), new SolidBrush(Color.White), 344, 88);
            //g.DrawString("胸围", new Font("微软雅黑", 16), new SolidBrush(Color.White), 490, 88);
            //g.DrawString("肩宽", new Font("微软雅黑", 16), new SolidBrush(Color.White), 630, 88);

            //g.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 140);
            //g.DrawString("51", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 140);
            //g.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 140);
            //g.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 140);
            //g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 140);

            //g.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 190);
            //g.DrawString("59", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 190);
            //g.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 190);
            //g.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 190);
            //g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 190);

            //g.DrawString("L", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 240);
            //g.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 240);
            //g.DrawString("48", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 240);
            //g.DrawString("108", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 240);
            //g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 240);

            //g.DrawString("XL", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 290);
            //g.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 290);
            //g.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 290);
            //g.DrawString("112", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 290);
            //g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 290);

            //g.DrawString("2XL", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 340);
            //g.DrawString("65", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 340);
            //g.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 340);
            //g.DrawString("116", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 340);
            //g.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 340);

            //g.DrawString("注意：均码是根据身高165CM,体重100斤来算的哟，只要身高误差不超过20CM,", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 80, 390);
            //g.DrawString("体重误差不超过20斤，都是可以穿的哟~~~", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 132, 410);
            //g.DrawString("温馨提示：由于手工测绘不通，1-2CM测量误差属于正常范围。", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 80, 432);

            //g.DrawString("REFERENCE X 试穿参考", new Font("微软雅黑", 20), new SolidBrush(Color.Black), 216, 480);

            //g.FillRectangle(new SolidBrush(Color.FromArgb(139, 139, 139)), 10, 540, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 586, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 636, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 686, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 736, 730, 50);
            //g.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 786, 730, 50);

            //g.DrawString("Model", new Font("微软雅黑", 16), new SolidBrush(Color.White), 48, 548);
            //g.DrawString("身高/体重", new Font("微软雅黑", 16), new SolidBrush(Color.White), 170, 548);
            //g.DrawString("三围", new Font("微软雅黑", 16), new SolidBrush(Color.White), 334, 548);
            //g.DrawString("试穿尺码", new Font("微软雅黑", 16), new SolidBrush(Color.White), 450, 548);
            //g.DrawString("试穿体验", new Font("微软雅黑", 16), new SolidBrush(Color.White), 600, 548);

            //g.DrawString("Ada", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 598);
            //g.DrawString("157/44", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 598);
            //g.DrawString("81/68/86", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 598);
            //g.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 598);
            //g.DrawString("穿着舒适", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 598);

            //g.DrawString("Lena", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 648);
            //g.DrawString("159/49", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 648);
            //g.DrawString("83/66/86", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 648);
            //g.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 648);
            //g.DrawString("刚刚好哟", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 648);

            //g.DrawString("Alice", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 698);
            //g.DrawString("162/53", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 698);
            //g.DrawString("88/70/90", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 698);
            //g.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 698);
            //g.DrawString("穿着舒适", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 698);

            //g.DrawString("Finn", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 748);
            //g.DrawString("165/59", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 748);
            //g.DrawString("91/76/98", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 748);
            //g.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 748);
            //g.DrawString("刚刚好哟", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 748);

            //g.DrawString("Erica", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 798);
            //g.DrawString("175/56", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 798);
            //g.DrawString("87/69/94", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 798);
            //g.DrawString("L", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 798);
            //g.DrawString("穿着舒适", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 798);

            //bmp.Save(@"E:\Picture\SAVE.Jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //bmp.Dispose();

            ////Application.DoEvents();

            Graphics eg = e.Graphics;
            eg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //eg.DrawString("SIZE X 尺码表", new Font("微软雅黑", 20), new SolidBrush(Color.Black), 276, 22);

            ////尺码表
            //eg.FillRectangle(new SolidBrush(Color.FromArgb(139, 139, 139)), 10, 80, 730, 50);
            //eg.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 126, 730, 50);
            //eg.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 176, 730, 50);
            //eg.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 226, 730, 50);
            //eg.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 276, 730, 50);
            //eg.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 326, 730, 50);

            //eg.DrawString("尺寸", new Font("微软雅黑", 16), new SolidBrush(Color.White), 68, 88);
            //eg.DrawString("衣长", new Font("微软雅黑", 16), new SolidBrush(Color.White), 198, 88);
            //eg.DrawString("袖长", new Font("微软雅黑", 16), new SolidBrush(Color.White), 344, 88);
            //eg.DrawString("胸围", new Font("微软雅黑", 16), new SolidBrush(Color.White), 490, 88);
            //eg.DrawString("肩宽", new Font("微软雅黑", 16), new SolidBrush(Color.White), 630, 88);

            //eg.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 140);
            //eg.DrawString("51", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 140);
            //eg.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 140);
            //eg.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 140);
            //eg.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 140);

            //eg.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 190);
            //eg.DrawString("59", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 190);
            //eg.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 190);
            //eg.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 190);
            //eg.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 190);

            //eg.DrawString("L", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 240);
            //eg.DrawString("61", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 240);
            //eg.DrawString("48", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 240);
            //eg.DrawString("108", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 240);
            //eg.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 240);

            //eg.DrawString("XL", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 290);
            //eg.DrawString("63", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 290);
            //eg.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 290);
            //eg.DrawString("112", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 290);
            //eg.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 290);

            //eg.DrawString("2XL", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 80, 340);
            //eg.DrawString("65", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 210, 340);
            //eg.DrawString("49", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 356, 340);
            //eg.DrawString("116", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 502, 340);
            //eg.DrawString("不限", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 632, 340);

            //eg.DrawString("注意：均码是根据身高165CM,体重100斤来算的哟，只要身高误差不超过20CM,", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 80, 390);
            //eg.DrawString("体重误差不超过20斤，都是可以穿的哟~~~", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 132, 410);
            //eg.DrawString("温馨提示：由于手工测绘不通，1-2CM测量误差属于正常范围。", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 80, 432);

            //eg.DrawString("REFERENCE X 试穿参考", new Font("微软雅黑", 20), new SolidBrush(Color.Black), 216, 480);

            //eg.FillRectangle(new SolidBrush(Color.FromArgb(139, 139, 139)), 10, 540, 730, 50);
            //eg.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 586, 730, 50);
            //eg.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 636, 730, 50);
            //eg.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 686, 730, 50);
            //eg.FillRectangle(new SolidBrush(Color.FromArgb(244, 244, 244)), 10, 736, 730, 50);
            //eg.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 239)), 10, 786, 730, 50);

            //eg.DrawString("Model", new Font("微软雅黑", 16), new SolidBrush(Color.White), 48, 548);
            //eg.DrawString("身高/体重", new Font("微软雅黑", 16), new SolidBrush(Color.White), 170, 548);
            //eg.DrawString("三围", new Font("微软雅黑", 16), new SolidBrush(Color.White), 334, 548);
            //eg.DrawString("试穿尺码", new Font("微软雅黑", 16), new SolidBrush(Color.White), 450, 548);
            //eg.DrawString("试穿体验", new Font("微软雅黑", 16), new SolidBrush(Color.White), 600, 548);

            //eg.DrawString("Ada", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 598);
            //eg.DrawString("157/44", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 598);
            //eg.DrawString("81/68/86", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 598);
            //eg.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 598);
            //eg.DrawString("穿着舒适", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 598);

            //eg.DrawString("Lena", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 648);
            //eg.DrawString("159/49", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 648);
            //eg.DrawString("83/66/86", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 648);
            //eg.DrawString("S", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 648);
            //eg.DrawString("刚刚好哟", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 648);

            //eg.DrawString("Alice", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 698);
            //eg.DrawString("162/53", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 698);
            //eg.DrawString("88/70/90", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 698);
            //eg.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 698);
            //eg.DrawString("穿着舒适", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 698);

            //eg.DrawString("Finn", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 748);
            //eg.DrawString("165/59", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 748);
            //eg.DrawString("91/76/98", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 748);
            //eg.DrawString("M", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 748);
            //eg.DrawString("刚刚好哟", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 748);

            //eg.DrawString("Erica", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 60, 798);
            //eg.DrawString("175/56", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 180, 798);
            //eg.DrawString("87/69/94", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 316, 798);
            //eg.DrawString("L", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 490, 798);
            //eg.DrawString("穿着舒适", new Font("黑体", 15), new SolidBrush(Color.FromArgb(36, 36, 36)), 600, 798);

            //Application.DoEvents();

            //go.DrawTableForMinimalist(e.Graphics, picBatchImage);
            //go.DrawTableForClear(picBatchImage, e.Graphics);
            eg.DrawString("MATERIALS & PATTERN X 面料版型", new Font("微软雅黑", 20), new SolidBrush(Color.Black), 140, 22);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(69, 69, 69)), 10, 80, 80, 80);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(197, 201, 200)), 90, 80, 650, 80);

            eg.FillRectangle(new SolidBrush(Color.FromArgb(197, 201, 200)), 10, 170, 180, 46);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 180, 170, 560, 46);
            //小方格
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 180, 170, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 320, 170, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 460, 170, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 600, 170, 140F, 46);

            eg.FillRectangle(new SolidBrush(Color.FromArgb(197, 201, 200)), 10, 222, 180, 46);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 180, 222, 560, 46);
            //小方格
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 180, 222, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 320, 222, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 460, 222, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 600, 222, 140F, 46);

            eg.FillRectangle(new SolidBrush(Color.FromArgb(197, 201, 200)), 10, 274, 180, 46);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 180, 274, 560, 46);
            //小方格
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 180, 274, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 320, 274, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 460, 274, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 600, 274, 140F, 46);

            eg.FillRectangle(new SolidBrush(Color.FromArgb(197, 201, 200)), 10, 326, 180, 46);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 180, 326, 560, 46);
            //小方格
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 180, 326, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 320, 326, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 460, 326, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 600, 326, 140F, 46);

            eg.FillRectangle(new SolidBrush(Color.FromArgb(197, 201, 200)), 10, 376, 180, 46);
            eg.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 180, 376, 560, 46);
            //小方格
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 180, 376, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 320, 376, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 460, 376, 140F, 46);
            eg.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(197, 201, 200))), 600, 376, 140F, 46);

            eg.DrawString("面料", new Font("微软雅黑", 16), new SolidBrush(Color.White), 24, 92);
            eg.DrawString("信息", new Font("微软雅黑", 16), new SolidBrush(Color.White), 24, 116);

            eg.DrawString("主料：棉60% 聚酯纤维40%   颜色：黑色", new Font("微软雅黑", 20), new SolidBrush(Color.Black), 106, 102);

            eg.DrawString("版型指数", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 46, 178);
            eg.DrawString("紧身", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 220, 178);
            eg.DrawString("修身", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 366, 178);
            eg.DrawString("合身", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 502, 178);
            eg.DrawString("宽松", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 648, 178);

            eg.DrawString("长度指数", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 46, 230);
            eg.DrawString("短款", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 220, 230);
            eg.DrawString("常规款", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 356, 230);
            eg.DrawString("中长款", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 492, 230);
            eg.DrawString("长款", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 648, 230);

            eg.DrawString("弹性指数", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 46, 282);
            eg.DrawString("不弹", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 220, 282);
            eg.DrawString("微弹", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 366, 282);
            eg.DrawString("中弹", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 502, 282);
            eg.DrawString("高弹", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 648, 282);

            eg.DrawString("厚度指数", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 46, 332);
            eg.DrawString("薄", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 230, 332);
            eg.DrawString("适中", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 366, 332);
            eg.DrawString("厚", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 512, 332);
            eg.DrawString("加厚", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 648, 332);

            eg.DrawString("透明指数", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 46, 382);
            eg.DrawString("不透", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 220, 382);
            eg.DrawString("适中", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 366, 382);
            eg.DrawString("微透", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 502, 382);
            eg.DrawString("超透", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 648, 382);

            eg.DrawString("温馨提示：(1) 建议手洗，最高温度40℃，侵泡时间不宜过长。洗涤时注意避开尖锐物体，", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 54, 438);
            eg.DrawString("装饰部分应分开洗涤。", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 136, 458);
            eg.DrawString("(2) 不可干洗，不可烘干，不可漂白，更不可暴晒。", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 136, 478);
            eg.DrawString("(3) 无需熨烫，不要大力搓揉，洗毕悬挂晾干即可。", new Font("微软雅黑", 12), new SolidBrush(Color.Black), 136, 498);
            //eg.DrawString("WARM TIPS X 温馨提示", new Font("微软雅黑", 20), new SolidBrush(Color.Black), 212, 392);
            //eg.DrawRectangle(new Pen(new SolidBrush(Color.Black)), 10, 448, 730, 200);
            //eg.DrawString("建议手洗，最高温度40℃，侵泡时间不宜过长。", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 144, 468);
            //eg.DrawString("洗涤时注意避开尖锐物体，装饰部分分开洗涤。", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 144, 508);
            //eg.DrawString("不可干洗，不可烘干，不可漂白，更不可暴晒。", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 144, 548);
            //eg.DrawString("无需熨烫，不要大力搓揉，洗毕悬挂晾干即可。", new Font("微软雅黑", 16), new SolidBrush(Color.Black), 144, 588);
        }

        private void btnOkaySet_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelSet_Click(object sender, EventArgs e)
        {
            this.pnlSizeSet.Hide();
        }

        /// <summary>
        /// http://bbs.csdn.net/topics/391872698 C#Winfom如何获取控件的滚动条位置并判断是否到达底部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDecorate_Paint(object sender, PaintEventArgs e)
        {
            //int axies = GetScrollPos(this.Handle, 1);
            //Console.WriteLine(axies);
            //this.pnlDecorate.Location = new Point(761, this.pnlDecorate.Height + axies);
        }

        private void pnlDecorate_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void btnFeature_Click(object sender, EventArgs e)
        {
            //using (Graphics g = Graphics.FromImage(picBatchImage.Image))
            //{
            //    //用白色清除图片
            //    g.Clear(Color.White);
            //}
            //picBatchImage.Invalidate();
            //this.picBatchImage.Refresh();

            //Graphics g = Graphics.FromImage(picBatchImage.Image);
            //g.Clear(Color.White);
            //g.Dispose();
            //picBatchImage.Refresh();
            this.picBatchImage.Paint += picBatchImage_Paint;

        }
    }
}
