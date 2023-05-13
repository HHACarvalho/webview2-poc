namespace webview2_poc
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.buttonScreenshot = new System.Windows.Forms.Button();
            this.offscreenWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.textUrlOffscreen = new System.Windows.Forms.TextBox();
            this.buttonScreenshotOffscreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainWebView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offscreenWebView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainWebView
            // 
            this.mainWebView.AllowExternalDrop = true;
            this.mainWebView.CreationProperties = null;
            this.mainWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.mainWebView.Location = new System.Drawing.Point(12, 41);
            this.mainWebView.Name = "mainWebView";
            this.mainWebView.Size = new System.Drawing.Size(1000, 523);
            this.mainWebView.Source = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            this.mainWebView.TabIndex = 0;
            this.mainWebView.ZoomFactor = 1D;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(12, 12);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(93, 14);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(838, 20);
            this.textUrl.TabIndex = 2;
            this.textUrl.Text = "https://www.google.com/";
            this.textUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textUrlEnter);
            // 
            // buttonScreenshot
            // 
            this.buttonScreenshot.Location = new System.Drawing.Point(937, 12);
            this.buttonScreenshot.Name = "buttonScreenshot";
            this.buttonScreenshot.Size = new System.Drawing.Size(75, 23);
            this.buttonScreenshot.TabIndex = 3;
            this.buttonScreenshot.Text = "Screenshot";
            this.buttonScreenshot.UseVisualStyleBackColor = true;
            this.buttonScreenshot.Click += new System.EventHandler(this.buttonScreenshot_Click);
            // 
            // offscreenWebView
            // 
            this.offscreenWebView.AllowExternalDrop = true;
            this.offscreenWebView.CreationProperties = null;
            this.offscreenWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.offscreenWebView.Location = new System.Drawing.Point(12, 700);
            this.offscreenWebView.Name = "offscreenWebView";
            this.offscreenWebView.Size = new System.Drawing.Size(1000, 523);
            this.offscreenWebView.Source = new System.Uri("https://www.youtube.com/", System.UriKind.Absolute);
            this.offscreenWebView.TabIndex = 4;
            this.offscreenWebView.TabStop = false;
            this.offscreenWebView.ZoomFactor = 1D;
            this.offscreenWebView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.requestScreenshot);
            // 
            // textUrlOffscreen
            // 
            this.textUrlOffscreen.Location = new System.Drawing.Point(12, 573);
            this.textUrlOffscreen.Name = "textUrlOffscreen";
            this.textUrlOffscreen.Size = new System.Drawing.Size(918, 20);
            this.textUrlOffscreen.TabIndex = 5;
            this.textUrlOffscreen.Text = "https://www.youtube.com/";
            // 
            // buttonScreenshotOffscreen
            // 
            this.buttonScreenshotOffscreen.Location = new System.Drawing.Point(936, 571);
            this.buttonScreenshotOffscreen.Name = "buttonScreenshotOffscreen";
            this.buttonScreenshotOffscreen.Size = new System.Drawing.Size(75, 23);
            this.buttonScreenshotOffscreen.TabIndex = 6;
            this.buttonScreenshotOffscreen.Text = "Screenshot";
            this.buttonScreenshotOffscreen.UseVisualStyleBackColor = true;
            this.buttonScreenshotOffscreen.Click += new System.EventHandler(this.buttonScreenshotOffscreen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 606);
            this.Controls.Add(this.buttonScreenshotOffscreen);
            this.Controls.Add(this.textUrlOffscreen);
            this.Controls.Add(this.offscreenWebView);
            this.Controls.Add(this.buttonScreenshot);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.mainWebView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WebView2 Application";
            ((System.ComponentModel.ISupportInitialize)(this.mainWebView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offscreenWebView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 mainWebView;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Button buttonScreenshot;
        private Microsoft.Web.WebView2.WinForms.WebView2 offscreenWebView;
        private System.Windows.Forms.TextBox textUrlOffscreen;
        private System.Windows.Forms.Button buttonScreenshotOffscreen;
    }
}
