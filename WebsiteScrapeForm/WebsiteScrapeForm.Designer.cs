namespace WebsiteScrapeForm
{
    partial class WebsiteScrapeForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnScrapeImage = new System.Windows.Forms.Button();
            this.txtUri = new System.Windows.Forms.TextBox();
            this.wbDownLoadImg = new System.Windows.Forms.WebBrowser();
            this.pnlDataList = new System.Windows.Forms.Panel();
            this.dgvDataList = new System.Windows.Forms.DataGridView();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.pgbStatus = new System.Windows.Forms.ProgressBar();
            this.lblStatusTip = new System.Windows.Forms.Label();
            this.pnlCollectConfirm = new System.Windows.Forms.Panel();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnCancelCollect = new System.Windows.Forms.Button();
            this.btnCollectStore = new System.Windows.Forms.Button();
            this.sfdWebSiteScrape = new System.Windows.Forms.SaveFileDialog();
            this.pnlDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            this.pnlStatus.SuspendLayout();
            this.pnlCollectConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScrapeImage
            // 
            this.btnScrapeImage.BackColor = System.Drawing.Color.DimGray;
            this.btnScrapeImage.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnScrapeImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnScrapeImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnScrapeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrapeImage.ForeColor = System.Drawing.Color.White;
            this.btnScrapeImage.Location = new System.Drawing.Point(636, 12);
            this.btnScrapeImage.Name = "btnScrapeImage";
            this.btnScrapeImage.Size = new System.Drawing.Size(180, 30);
            this.btnScrapeImage.TabIndex = 0;
            this.btnScrapeImage.Text = "查看网页并下载图片";
            this.btnScrapeImage.UseVisualStyleBackColor = false;
            this.btnScrapeImage.Click += new System.EventHandler(this.btnScrapeImage_Click);
            // 
            // txtUri
            // 
            this.txtUri.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUri.Location = new System.Drawing.Point(12, 14);
            this.txtUri.Multiline = true;
            this.txtUri.Name = "txtUri";
            this.txtUri.Size = new System.Drawing.Size(600, 25);
            this.txtUri.TabIndex = 1;
            // 
            // wbDownLoadImg
            // 
            this.wbDownLoadImg.Location = new System.Drawing.Point(2, 53);
            this.wbDownLoadImg.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDownLoadImg.Name = "wbDownLoadImg";
            this.wbDownLoadImg.Size = new System.Drawing.Size(820, 494);
            this.wbDownLoadImg.TabIndex = 2;
            this.wbDownLoadImg.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbDownLoadImg_DocumentCompleted);
            // 
            // pnlDataList
            // 
            this.pnlDataList.BackColor = System.Drawing.Color.DimGray;
            this.pnlDataList.Controls.Add(this.dgvDataList);
            this.pnlDataList.Location = new System.Drawing.Point(147, 92);
            this.pnlDataList.Name = "pnlDataList";
            this.pnlDataList.Size = new System.Drawing.Size(675, 440);
            this.pnlDataList.TabIndex = 3;
            this.pnlDataList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDataList_MouseDown);
            this.pnlDataList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDataList_MouseMove);
            this.pnlDataList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDataList_MouseUp);
            // 
            // dgvDataList
            // 
            this.dgvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataList.Location = new System.Drawing.Point(3, 56);
            this.dgvDataList.Name = "dgvDataList";
            this.dgvDataList.RowTemplate.Height = 23;
            this.dgvDataList.Size = new System.Drawing.Size(669, 381);
            this.dgvDataList.TabIndex = 0;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.DimGray;
            this.pnlStatus.Controls.Add(this.pgbStatus);
            this.pnlStatus.Controls.Add(this.lblStatusTip);
            this.pnlStatus.Location = new System.Drawing.Point(2, 468);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(300, 65);
            this.pnlStatus.TabIndex = 4;
            this.pnlStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlStatus_MouseDown);
            this.pnlStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlStatus_MouseMove);
            this.pnlStatus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlStatus_MouseUp);
            // 
            // pgbStatus
            // 
            this.pgbStatus.ForeColor = System.Drawing.Color.Cyan;
            this.pgbStatus.Location = new System.Drawing.Point(12, 37);
            this.pgbStatus.Name = "pgbStatus";
            this.pgbStatus.Size = new System.Drawing.Size(275, 4);
            this.pgbStatus.TabIndex = 1;
            // 
            // lblStatusTip
            // 
            this.lblStatusTip.AutoSize = true;
            this.lblStatusTip.ForeColor = System.Drawing.Color.White;
            this.lblStatusTip.Location = new System.Drawing.Point(9, 17);
            this.lblStatusTip.Name = "lblStatusTip";
            this.lblStatusTip.Size = new System.Drawing.Size(29, 12);
            this.lblStatusTip.TabIndex = 0;
            this.lblStatusTip.Text = "提示";
            // 
            // pnlCollectConfirm
            // 
            this.pnlCollectConfirm.Controls.Add(this.lblTip);
            this.pnlCollectConfirm.Controls.Add(this.btnCancelCollect);
            this.pnlCollectConfirm.Controls.Add(this.btnCollectStore);
            this.pnlCollectConfirm.Location = new System.Drawing.Point(497, 53);
            this.pnlCollectConfirm.Name = "pnlCollectConfirm";
            this.pnlCollectConfirm.Size = new System.Drawing.Size(308, 159);
            this.pnlCollectConfirm.TabIndex = 5;
            this.pnlCollectConfirm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCollectConfirm_MouseDown);
            this.pnlCollectConfirm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCollectConfirm_MouseMove);
            this.pnlCollectConfirm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCollectConfirm_MouseUp);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTip.ForeColor = System.Drawing.Color.White;
            this.lblTip.Location = new System.Drawing.Point(98, 52);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(122, 21);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "是否收藏本站？";
            // 
            // btnCancelCollect
            // 
            this.btnCancelCollect.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelCollect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCollect.ForeColor = System.Drawing.Color.White;
            this.btnCancelCollect.Location = new System.Drawing.Point(165, 112);
            this.btnCancelCollect.Name = "btnCancelCollect";
            this.btnCancelCollect.Size = new System.Drawing.Size(112, 30);
            this.btnCancelCollect.TabIndex = 1;
            this.btnCancelCollect.Text = "取消";
            this.btnCancelCollect.UseVisualStyleBackColor = true;
            this.btnCancelCollect.Click += new System.EventHandler(this.btnCancelCollect_Click);
            // 
            // btnCollectStore
            // 
            this.btnCollectStore.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnCollectStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollectStore.ForeColor = System.Drawing.Color.White;
            this.btnCollectStore.Location = new System.Drawing.Point(35, 112);
            this.btnCollectStore.Name = "btnCollectStore";
            this.btnCollectStore.Size = new System.Drawing.Size(112, 30);
            this.btnCollectStore.TabIndex = 0;
            this.btnCollectStore.Text = "收藏本店";
            this.btnCollectStore.UseVisualStyleBackColor = true;
            this.btnCollectStore.Click += new System.EventHandler(this.btnCollectStore_Click);
            // 
            // WebsiteScrapeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(825, 544);
            this.Controls.Add(this.pnlCollectConfirm);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlDataList);
            this.Controls.Add(this.wbDownLoadImg);
            this.Controls.Add(this.txtUri);
            this.Controls.Add(this.btnScrapeImage);
            this.Name = "WebsiteScrapeForm";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.WebsiteScrapeForm_SizeChanged);
            this.pnlDataList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlCollectConfirm.ResumeLayout(false);
            this.pnlCollectConfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScrapeImage;
        private System.Windows.Forms.TextBox txtUri;
        private System.Windows.Forms.WebBrowser wbDownLoadImg;
        private System.Windows.Forms.Panel pnlDataList;
        private System.Windows.Forms.DataGridView dgvDataList;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.ProgressBar pgbStatus;
        private System.Windows.Forms.Label lblStatusTip;
        private System.Windows.Forms.Panel pnlCollectConfirm;
        private System.Windows.Forms.Button btnCancelCollect;
        private System.Windows.Forms.Button btnCollectStore;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.SaveFileDialog sfdWebSiteScrape;
    }
}

