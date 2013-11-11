namespace Website_Downloader
{
    partial class Form5
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
            this.url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.forward = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(202, 48);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(470, 20);
            this.url.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Preview the website:\r\n";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(8, 79);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1000, 653);
            this.webBrowser.TabIndex = 19;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // forward
            // 
            this.forward.Image = global::Website_Downloader.Properties.Resources.Button_Fast_Forward_icon;
            this.forward.Location = new System.Drawing.Point(110, 41);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(32, 32);
            this.forward.TabIndex = 26;
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // back
            // 
            this.back.Image = global::Website_Downloader.Properties.Resources.Button_Rewind_icon;
            this.back.Location = new System.Drawing.Point(76, 41);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(32, 32);
            this.back.TabIndex = 25;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // cancle
            // 
            this.cancle.Image = global::Website_Downloader.Properties.Resources.Button_Close_icon;
            this.cancle.Location = new System.Drawing.Point(42, 41);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(32, 32);
            this.cancle.TabIndex = 24;
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // refresh
            // 
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refresh.Image = global::Website_Downloader.Properties.Resources.Button_Refresh_icon;
            this.refresh.Location = new System.Drawing.Point(8, 41);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(32, 32);
            this.refresh.TabIndex = 23;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // search
            // 
            this.search.Image = global::Website_Downloader.Properties.Resources.Button_Play_icon;
            this.search.Location = new System.Drawing.Point(678, 41);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(32, 32);
            this.search.TabIndex = 22;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Address:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 744);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.search);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label label2;
    }
}