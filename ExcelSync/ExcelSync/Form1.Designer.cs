namespace ExcelSync
{
    partial class Form1
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.filepath = new System.Windows.Forms.Label();
            this.selectFilePath = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.reportButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.TitleLabel.Location = new System.Drawing.Point(45, 45);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(550, 50);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "QuickBooks Connector";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectFileButton.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.selectFileButton.Location = new System.Drawing.Point(145, 120);
            this.selectFileButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(350, 35);
            this.selectFileButton.TabIndex = 1;
            this.selectFileButton.Text = "Select Beulah Financial Report File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.status.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.status.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.status.Location = new System.Drawing.Point(88, 265);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(465, 30);
            this.status.TabIndex = 2;
            this.status.Text = "Import Status";
            this.status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // filepath
            // 
            this.filepath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filepath.AutoEllipsis = true;
            this.filepath.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.filepath.Location = new System.Drawing.Point(88, 310);
            this.filepath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(465, 25);
            this.filepath.TabIndex = 3;
            this.filepath.Text = "Placeholder Progress Text";
            this.filepath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectFilePath
            // 
            this.selectFilePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectFilePath.AutoEllipsis = true;
            this.selectFilePath.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.selectFilePath.Location = new System.Drawing.Point(30, 170);
            this.selectFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectFilePath.Name = "selectFilePath";
            this.selectFilePath.Size = new System.Drawing.Size(580, 20);
            this.selectFilePath.TabIndex = 4;
            this.selectFilePath.Text = "Placeholder File Path Text";
            this.selectFilePath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // importButton
            // 
            this.importButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importButton.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.importButton.Location = new System.Drawing.Point(158, 205);
            this.importButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(325, 35);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "Import Data To QuickBooks";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.Location = new System.Drawing.Point(170, 350);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 25);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            // 
            // reportButton
            // 
            this.reportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportButton.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.reportButton.Location = new System.Drawing.Point(240, 390);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(160, 35);
            this.reportButton.TabIndex = 7;
            this.reportButton.Text = "View Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.helpButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.helpButton.Location = new System.Drawing.Point(12, 414);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(60, 35);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(185)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.selectFilePath);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.status);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximumSize = new System.Drawing.Size(700, 550);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickBooks Connector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label filepath;
        internal System.Windows.Forms.Label status;
        private System.Windows.Forms.Label selectFilePath;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button helpButton;
    }
}

