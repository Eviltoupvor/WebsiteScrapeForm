using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBLL.ScrapeBLL;

namespace WebsiteScrapeForm
{
    /// <summary>
    /// http://www.cnblogs.com/encoding/p/5603080.html [DForm]我也来做自定义Winform之另类标题栏重绘
    /// </summary>
    public partial class WebsiteScrapeForm : Form
    {
        private WebsiteCrawlerBLL wcb;
        private Point pnlDataListOffset;
        private Point pnlStatusOffset;
        private Point pnlCollectConfirmOffset;

        /// <summary>
        /// https://jingyan.baidu.com/article/2c8c281dce37ce0008252a3f.html 如何设置C#窗体大小不能改变
        /// </summary>
        public WebsiteScrapeForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.pnlCollectConfirm.Hide();
            this.pnlStatus.Hide();
            wcb = new WebsiteCrawlerBLL();
        }

        private void btnScrapeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            wbDownLoadImg.Navigate(txtUri.Text);
        }

        private void wbDownLoadImg_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (wbDownLoadImg.ReadyState == WebBrowserReadyState.Complete )
            {
                this.pnlCollectConfirm.Show();
                this.pnlStatus.Show();
                // wcb.DownLoadScrapedImages(@"E:\Picture\ImgSrc01.txt");
                lblStatusTip.Text = wcb.ScrapeWebImagesSrc(wbDownLoadImg.DocumentText, @"E:\Picture\ImgSrc.txt");
                //wcb.AlicdnStoreLogoSrc(@"E:\Picture\ImgSrc.txt", @"E:\Picture\ImgStoreLogoSrc.txt");
                //wcb.AlicdnImgextraSrc(@"E:\Picture\ImgSrc.txt", @"E:\Picture\ImgImgextraSrc.txt");
                lblStatusTip.Text = wcb.AlicdnBaoUploadedSrc(@"E:\Picture\ImgSrc.txt", @"E:\Picture\ImgBaoUploaded.txt");
            }
        }

        private void WebsiteScrapeForm_SizeChanged(object sender, EventArgs e)
        {
            this.wbDownLoadImg.Width = this.Width;
            this.wbDownLoadImg.Height = this.Height;
            this.txtUri.Width = (int)(this.Width * 0.83);
            this.btnScrapeImage.Location = new Point(this.txtUri.Width + 18,12);
            this.pnlDataList.Location = new Point(this.Width - 675,this.Height - 480);
            this.pnlStatus.Location = new Point(0,this.Height - 99);
            this.pnlCollectConfirm.Location = new Point(this.Width - 320 , 54);
        }

        private void pnlCollectConfirm_MouseDown(object sender, MouseEventArgs e)
        {
            pnlCollectConfirmOffset.X = e.X;
            pnlCollectConfirmOffset.Y = e.Y;
        }

        private void pnlCollectConfirm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int left = pnlCollectConfirm.Left + e.X - pnlCollectConfirmOffset.X;
                int top = pnlCollectConfirm.Top + e.Y - pnlCollectConfirmOffset.Y;
                pnlCollectConfirm.Location = new Point(left, top);
            }
        }

        private void pnlCollectConfirm_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pnlStatus_MouseDown(object sender, MouseEventArgs e)
        {
            pnlStatusOffset.X = e.X;
            pnlStatusOffset.Y = e.Y;
        }

        private void pnlStatus_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int left = pnlStatus.Left + e.X - pnlStatusOffset.X;
                int top = pnlStatus.Top + e.Y - pnlStatusOffset.Y;
                pnlStatus.Location = new Point(left, top);
            }
        }

        private void pnlStatus_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pnlDataList_MouseDown(object sender, MouseEventArgs e)
        {
            pnlDataListOffset.X = e.X;
            pnlDataListOffset.Y = e.Y;
        }

        private void pnlDataList_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int left = pnlDataList.Left + e.X - pnlDataListOffset.X;
                int top = pnlDataList.Top + e.Y - pnlDataListOffset.Y;
                pnlDataList.Location = new Point(left, top);
            }
        }

        private void pnlDataList_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnCollectStore_Click(object sender, EventArgs e)
        {
            string text = wbDownLoadImg.DocumentTitle;
            string url = wbDownLoadImg.Url.ToString();
            Console.WriteLine("当前网页标题"+ text +Environment.NewLine + "当前网页网址" + url);
        }

        private void btnCancelCollect_Click(object sender, EventArgs e)
        {
            this.pnlCollectConfirm.Hide();
        }
    }
}
