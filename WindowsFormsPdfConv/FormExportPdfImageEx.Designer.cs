namespace WindowsFormsPdfConv
{
    partial class FormExportPdfImageEx
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDirPath = new System.Windows.Forms.TextBox();
            this.buttonExportPdfImage = new System.Windows.Forms.Button();
            this.listBoxExpPdfImg = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxDirPath
            // 
            this.textBoxDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirPath.Location = new System.Drawing.Point(14, 12);
            this.textBoxDirPath.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxDirPath.Name = "textBoxDirPath";
            this.textBoxDirPath.Size = new System.Drawing.Size(552, 25);
            this.textBoxDirPath.TabIndex = 12;
            this.textBoxDirPath.Text = "C:\\tmp";
            // 
            // buttonExportPdfImage
            // 
            this.buttonExportPdfImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExportPdfImage.Location = new System.Drawing.Point(14, 762);
            this.buttonExportPdfImage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonExportPdfImage.Name = "buttonExportPdfImage";
            this.buttonExportPdfImage.Size = new System.Drawing.Size(552, 73);
            this.buttonExportPdfImage.TabIndex = 14;
            this.buttonExportPdfImage.Text = "Pdf 画像抽出";
            this.buttonExportPdfImage.UseVisualStyleBackColor = true;
            this.buttonExportPdfImage.Click += new System.EventHandler(this.buttonExportPdfImage_Click);
            // 
            // listBoxExpPdfImg
            // 
            this.listBoxExpPdfImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxExpPdfImg.FormattingEnabled = true;
            this.listBoxExpPdfImg.ItemHeight = 18;
            this.listBoxExpPdfImg.Location = new System.Drawing.Point(14, 50);
            this.listBoxExpPdfImg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBoxExpPdfImg.Name = "listBoxExpPdfImg";
            this.listBoxExpPdfImg.Size = new System.Drawing.Size(552, 706);
            this.listBoxExpPdfImg.TabIndex = 11;
            // 
            // FormExportPdfImageEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 840);
            this.Controls.Add(this.buttonExportPdfImage);
            this.Controls.Add(this.textBoxDirPath);
            this.Controls.Add(this.listBoxExpPdfImg);
            this.Name = "FormExportPdfImageEx";
            this.Text = "Export Pdf Image Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDirPath;
        private System.Windows.Forms.Button buttonExportPdfImage;
        private System.Windows.Forms.ListBox listBoxExpPdfImg;
    }
}

