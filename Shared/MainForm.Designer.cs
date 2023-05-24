namespace Shared
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
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonScreenshot = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.textBoxUrlOffscreen = new System.Windows.Forms.TextBox();
            this.buttonScreenshotOffscreen = new System.Windows.Forms.Button();
            this.webViewOffscreen = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webViewOffscreen)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGo.Location = new System.Drawing.Point(12, 12);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(93, 14);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(838, 20);
            this.textBoxUrl.TabIndex = 1;
            this.textBoxUrl.Text = "https://www.google.com/";
            this.textBoxUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxUrl_Enter);
            // 
            // buttonScreenshot
            // 
            this.buttonScreenshot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonScreenshot.Location = new System.Drawing.Point(937, 12);
            this.buttonScreenshot.Name = "buttonScreenshot";
            this.buttonScreenshot.Size = new System.Drawing.Size(75, 23);
            this.buttonScreenshot.TabIndex = 2;
            this.buttonScreenshot.Text = "Screenshot";
            this.buttonScreenshot.UseVisualStyleBackColor = true;
            this.buttonScreenshot.Click += new System.EventHandler(this.ButtonScreenshot_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(12, 41);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1000, 523);
            this.webView.TabIndex = 3;
            this.webView.ZoomFactor = 1D;
            // 
            // textBoxUrlOffscreen
            // 
            this.textBoxUrlOffscreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxUrlOffscreen.Location = new System.Drawing.Point(12, 573);
            this.textBoxUrlOffscreen.Name = "textBoxUrlOffscreen";
            this.textBoxUrlOffscreen.Size = new System.Drawing.Size(918, 20);
            this.textBoxUrlOffscreen.TabIndex = 4;
            this.textBoxUrlOffscreen.Text = "https://www.youtube.com/";
            this.textBoxUrlOffscreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxUrlOffscreen_Enter);
            // 
            // buttonScreenshotOffscreen
            // 
            this.buttonScreenshotOffscreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonScreenshotOffscreen.Location = new System.Drawing.Point(936, 571);
            this.buttonScreenshotOffscreen.Name = "buttonScreenshotOffscreen";
            this.buttonScreenshotOffscreen.Size = new System.Drawing.Size(75, 23);
            this.buttonScreenshotOffscreen.TabIndex = 5;
            this.buttonScreenshotOffscreen.Text = "Screenshot";
            this.buttonScreenshotOffscreen.UseVisualStyleBackColor = true;
            this.buttonScreenshotOffscreen.Click += new System.EventHandler(this.ButtonScreenshotOffscreen_Click);
            // 
            // webViewOffscreen
            // 
            this.webViewOffscreen.AllowExternalDrop = true;
            this.webViewOffscreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.webViewOffscreen.CreationProperties = null;
            this.webViewOffscreen.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewOffscreen.Location = new System.Drawing.Point(12, 650);
            this.webViewOffscreen.Name = "webViewOffscreen";
            this.webViewOffscreen.Size = new System.Drawing.Size(1920, 1080);
            this.webViewOffscreen.TabIndex = 6;
            this.webViewOffscreen.TabStop = false;
            this.webViewOffscreen.ZoomFactor = 1D;
            this.webViewOffscreen.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.WebviewOffscreen_NavigationCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 606);
            this.Controls.Add(this.webViewOffscreen);
            this.Controls.Add(this.buttonScreenshotOffscreen);
            this.Controls.Add(this.textBoxUrlOffscreen);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.buttonScreenshot);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.buttonGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WebView2 Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webViewOffscreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button buttonScreenshot;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.TextBox textBoxUrlOffscreen;
        private System.Windows.Forms.Button buttonScreenshotOffscreen;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewOffscreen;
    }
}

