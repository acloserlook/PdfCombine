namespace PdfCombine
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.Pages = new System.Windows.Forms.ListBox();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.RemovePage = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.PageThumbnail = new System.Windows.Forms.PictureBox();
            this.Splitter = new System.Windows.Forms.SplitContainer();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.PageThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Splitter)).BeginInit();
            this.Splitter.Panel1.SuspendLayout();
            this.Splitter.Panel2.SuspendLayout();
            this.Splitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pages
            // 
            this.Pages.DisplayMember = "Title";
            this.Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pages.FormattingEnabled = true;
            this.Pages.ItemHeight = 15;
            this.Pages.Location = new System.Drawing.Point(0, 0);
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(401, 334);
            this.Pages.TabIndex = 0;
            this.Pages.ValueMember = "PageNumber";
            this.Pages.SelectedIndexChanged += new System.EventHandler(this.Pages_SelectedIndexChanged);
            // 
            // MoveUp
            // 
            this.MoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveUp.Location = new System.Drawing.Point(753, 12);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(75, 23);
            this.MoveUp.TabIndex = 1;
            this.MoveUp.Text = "Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveDown.Location = new System.Drawing.Point(753, 41);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(75, 23);
            this.MoveDown.TabIndex = 2;
            this.MoveDown.Text = "Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // RemovePage
            // 
            this.RemovePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemovePage.Location = new System.Drawing.Point(753, 90);
            this.RemovePage.Name = "RemovePage";
            this.RemovePage.Size = new System.Drawing.Size(75, 23);
            this.RemovePage.TabIndex = 3;
            this.RemovePage.Text = "Remove";
            this.RemovePage.UseVisualStyleBackColor = true;
            this.RemovePage.Click += new System.EventHandler(this.RemovePage_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save.Location = new System.Drawing.Point(12, 352);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // PageThumbnail
            // 
            this.PageThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageThumbnail.Location = new System.Drawing.Point(0, 0);
            this.PageThumbnail.Name = "PageThumbnail";
            this.PageThumbnail.Size = new System.Drawing.Size(330, 334);
            this.PageThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PageThumbnail.TabIndex = 5;
            this.PageThumbnail.TabStop = false;
            // 
            // Splitter
            // 
            this.Splitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Splitter.IsSplitterFixed = true;
            this.Splitter.Location = new System.Drawing.Point(12, 12);
            this.Splitter.Name = "Splitter";
            // 
            // Splitter.Panel1
            // 
            this.Splitter.Panel1.Controls.Add(this.Pages);
            // 
            // Splitter.Panel2
            // 
            this.Splitter.Panel2.Controls.Add(this.PageThumbnail);
            this.Splitter.Size = new System.Drawing.Size(735, 334);
            this.Splitter.SplitterDistance = 401;
            this.Splitter.TabIndex = 0;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressBar.Location = new System.Drawing.Point(93, 352);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(320, 23);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 5;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 387);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Splitter);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.RemovePage);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.MoveUp);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(856, 426);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit File - PdfCombine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditForm_FormClosed);
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PageThumbnail)).EndInit();
            this.Splitter.Panel1.ResumeLayout(false);
            this.Splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Splitter)).EndInit();
            this.Splitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Pages;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Button RemovePage;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.PictureBox PageThumbnail;
        private System.Windows.Forms.SplitContainer Splitter;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}