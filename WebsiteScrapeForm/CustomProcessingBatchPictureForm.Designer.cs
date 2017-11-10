namespace WebsiteScrapeForm
{
    partial class CustomProcessingBatchPictureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomProcessingBatchPictureForm));
            this.btnProcessBatch = new System.Windows.Forms.Button();
            this.btnSizeSet = new System.Windows.Forms.Button();
            this.picBatchImage = new System.Windows.Forms.PictureBox();
            this.sfdPictureBox = new System.Windows.Forms.SaveFileDialog();
            this.pnlSizeSet = new System.Windows.Forms.Panel();
            this.btnCancelSet = new System.Windows.Forms.Button();
            this.btnOkaySet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.grpSelectSize = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pnlDecorate = new System.Windows.Forms.Panel();
            this.btnFeature = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBatchImage)).BeginInit();
            this.pnlSizeSet.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpSelectSize.SuspendLayout();
            this.pnlDecorate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcessBatch
            // 
            this.btnProcessBatch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProcessBatch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnProcessBatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnProcessBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessBatch.Location = new System.Drawing.Point(18, 14);
            this.btnProcessBatch.Name = "btnProcessBatch";
            this.btnProcessBatch.Size = new System.Drawing.Size(93, 37);
            this.btnProcessBatch.TabIndex = 0;
            this.btnProcessBatch.Text = "主图批处理";
            this.btnProcessBatch.UseVisualStyleBackColor = true;
            this.btnProcessBatch.Click += new System.EventHandler(this.btnProcessBatch_Click);
            // 
            // btnSizeSet
            // 
            this.btnSizeSet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSizeSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSizeSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSizeSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSizeSet.ForeColor = System.Drawing.Color.White;
            this.btnSizeSet.Location = new System.Drawing.Point(18, 57);
            this.btnSizeSet.Name = "btnSizeSet";
            this.btnSizeSet.Size = new System.Drawing.Size(93, 37);
            this.btnSizeSet.TabIndex = 1;
            this.btnSizeSet.Text = "尺寸设置页";
            this.btnSizeSet.UseVisualStyleBackColor = true;
            this.btnSizeSet.Click += new System.EventHandler(this.btnSizeSet_Click);
            // 
            // picBatchImage
            // 
            this.picBatchImage.BackColor = System.Drawing.Color.NavajoWhite;
            this.picBatchImage.Image = ((System.Drawing.Image)(resources.GetObject("picBatchImage.Image")));
            this.picBatchImage.Location = new System.Drawing.Point(12, 12);
            this.picBatchImage.Name = "picBatchImage";
            this.picBatchImage.Size = new System.Drawing.Size(750, 880);
            this.picBatchImage.TabIndex = 2;
            this.picBatchImage.TabStop = false;
            this.picBatchImage.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.picBatchImage_LoadCompleted);
            this.picBatchImage.Click += new System.EventHandler(this.picBatchImage_Click);
            this.picBatchImage.Paint += new System.Windows.Forms.PaintEventHandler(this.picBatchImage_Paint);
            this.picBatchImage.Resize += new System.EventHandler(this.picBatchImage_Resize);
            // 
            // pnlSizeSet
            // 
            this.pnlSizeSet.BackColor = System.Drawing.Color.DimGray;
            this.pnlSizeSet.Controls.Add(this.btnCancelSet);
            this.pnlSizeSet.Controls.Add(this.btnOkaySet);
            this.pnlSizeSet.Controls.Add(this.groupBox2);
            this.pnlSizeSet.Controls.Add(this.groupBox1);
            this.pnlSizeSet.Controls.Add(this.grpSelectSize);
            this.pnlSizeSet.Location = new System.Drawing.Point(223, 173);
            this.pnlSizeSet.Name = "pnlSizeSet";
            this.pnlSizeSet.Size = new System.Drawing.Size(392, 234);
            this.pnlSizeSet.TabIndex = 3;
            this.pnlSizeSet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSizeSet_MouseDown);
            this.pnlSizeSet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSizeSet_MouseMove);
            // 
            // btnCancelSet
            // 
            this.btnCancelSet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCancelSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCancelSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelSet.Location = new System.Drawing.Point(197, 182);
            this.btnCancelSet.Name = "btnCancelSet";
            this.btnCancelSet.Size = new System.Drawing.Size(95, 30);
            this.btnCancelSet.TabIndex = 5;
            this.btnCancelSet.Text = "取消";
            this.btnCancelSet.UseVisualStyleBackColor = true;
            this.btnCancelSet.Click += new System.EventHandler(this.btnCancelSet_Click);
            // 
            // btnOkaySet
            // 
            this.btnOkaySet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOkaySet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnOkaySet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnOkaySet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkaySet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOkaySet.Location = new System.Drawing.Point(93, 182);
            this.btnOkaySet.Name = "btnOkaySet";
            this.btnOkaySet.Size = new System.Drawing.Size(95, 30);
            this.btnOkaySet.TabIndex = 4;
            this.btnOkaySet.Text = "确定";
            this.btnOkaySet.UseVisualStyleBackColor = true;
            this.btnOkaySet.Click += new System.EventHandler(this.btnOkaySet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Controls.Add(this.radioButton10);
            this.groupBox2.Enabled = false;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(197, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 62);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "表格放置";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(92, 27);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(47, 16);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "偏右";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(31, 26);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(47, 16);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "偏左";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 62);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "表格比例";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(93, 25);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(47, 16);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "100%";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(31, 25);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(41, 16);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "2/3";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // grpSelectSize
            // 
            this.grpSelectSize.Controls.Add(this.radioButton6);
            this.grpSelectSize.Controls.Add(this.radioButton5);
            this.grpSelectSize.Controls.Add(this.radioButton4);
            this.grpSelectSize.Controls.Add(this.radioButton3);
            this.grpSelectSize.Controls.Add(this.radioButton2);
            this.grpSelectSize.Controls.Add(this.radioButton1);
            this.grpSelectSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSelectSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpSelectSize.Location = new System.Drawing.Point(24, 91);
            this.grpSelectSize.Name = "grpSelectSize";
            this.grpSelectSize.Size = new System.Drawing.Size(346, 75);
            this.grpSelectSize.TabIndex = 0;
            this.grpSelectSize.TabStop = false;
            this.grpSelectSize.Text = "衣服尺寸";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(254, 45);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(71, 16);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "S -- 3XL";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(127, 45);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(95, 16);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "S,M,L,XL,2XL";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(19, 45);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "S,M,L,XL";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(254, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "S,M,L";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(127, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "S,M";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(19, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(29, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "S";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pnlDecorate
            // 
            this.pnlDecorate.Controls.Add(this.btnFeature);
            this.pnlDecorate.Controls.Add(this.btnProcessBatch);
            this.pnlDecorate.Controls.Add(this.btnSizeSet);
            this.pnlDecorate.Location = new System.Drawing.Point(768, -2);
            this.pnlDecorate.Name = "pnlDecorate";
            this.pnlDecorate.Size = new System.Drawing.Size(124, 528);
            this.pnlDecorate.TabIndex = 4;
            this.pnlDecorate.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlDecorate_Scroll);
            this.pnlDecorate.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDecorate_Paint);
            // 
            // btnFeature
            // 
            this.btnFeature.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFeature.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnFeature.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnFeature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeature.ForeColor = System.Drawing.Color.White;
            this.btnFeature.Location = new System.Drawing.Point(17, 102);
            this.btnFeature.Name = "btnFeature";
            this.btnFeature.Size = new System.Drawing.Size(93, 37);
            this.btnFeature.TabIndex = 2;
            this.btnFeature.Text = "面料版型页";
            this.btnFeature.UseVisualStyleBackColor = true;
            this.btnFeature.Click += new System.EventHandler(this.btnFeature_Click);
            // 
            // CustomProcessingBatchPictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 800);
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(911, 525);
            this.Controls.Add(this.pnlDecorate);
            this.Controls.Add(this.pnlSizeSet);
            this.Controls.Add(this.picBatchImage);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomProcessingBatchPictureForm";
            this.Text = "Custom Processing Batch Picture";
            this.Load += new System.EventHandler(this.CustomProcessingBatchPictureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBatchImage)).EndInit();
            this.pnlSizeSet.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSelectSize.ResumeLayout(false);
            this.grpSelectSize.PerformLayout();
            this.pnlDecorate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcessBatch;
        private System.Windows.Forms.Button btnSizeSet;
        private System.Windows.Forms.SaveFileDialog sfdPictureBox;
        public System.Windows.Forms.PictureBox picBatchImage;
        private System.Windows.Forms.Panel pnlSizeSet;
        private System.Windows.Forms.GroupBox grpSelectSize;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnCancelSet;
        private System.Windows.Forms.Button btnOkaySet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Panel pnlDecorate;
        private System.Windows.Forms.Button btnFeature;
    }
}