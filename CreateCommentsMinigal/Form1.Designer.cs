namespace CreateCommentsMinigal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.btLoadPictures = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrevious = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(15, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1059, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(148, 15);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(368, 20);
            this.txtPath.TabIndex = 2;
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(81, 706);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(993, 85);
            this.txtComment.TabIndex = 3;
            this.txtComment.Text = "";
            // 
            // btLoadPictures
            // 
            this.btLoadPictures.Location = new System.Drawing.Point(522, 13);
            this.btLoadPictures.Name = "btLoadPictures";
            this.btLoadPictures.Size = new System.Drawing.Size(128, 23);
            this.btLoadPictures.TabIndex = 4;
            this.btLoadPictures.Text = "Load pictures";
            this.btLoadPictures.UseVisualStyleBackColor = true;
            this.btLoadPictures.Click += new System.EventHandler(this.btLoadPictures_Click);
            // 
            // btNext
            // 
            this.btNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btNext.Location = new System.Drawing.Point(539, 665);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 5;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPrevious
            // 
            this.btPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btPrevious.Location = new System.Drawing.Point(458, 665);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(75, 23);
            this.btPrevious.TabIndex = 6;
            this.btPrevious.Text = "Previous";
            this.btPrevious.UseVisualStyleBackColor = true;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 709);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Comment:";
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Location = new System.Drawing.Point(458, 797);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(128, 23);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(15, 13);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(127, 23);
            this.btSearch.TabIndex = 9;
            this.btSearch.Text = "Select folder path";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 837);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btPrevious);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btLoadPictures);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Minigal Nano Comments Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Button btLoadPictures;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPrevious;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btSearch;
    }
}

