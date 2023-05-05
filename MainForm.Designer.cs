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
            this.webViewWindow = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textUrl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.webViewWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // webViewWindow
            // 
            this.webViewWindow.AllowExternalDrop = true;
            this.webViewWindow.CreationProperties = null;
            this.webViewWindow.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewWindow.Location = new System.Drawing.Point(12, 41);
            this.webViewWindow.Name = "webViewWindow";
            this.webViewWindow.Size = new System.Drawing.Size(876, 547);
            this.webViewWindow.Source = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            this.webViewWindow.TabIndex = 0;
            this.webViewWindow.ZoomFactor = 1D;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 12);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(93, 14);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(794, 20);
            this.textUrl.TabIndex = 2;
            this.textUrl.Text = "https://www.google.com/";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.webViewWindow);
            this.Name = "MainForm";
            this.Text = "WebView2 Application";
            ((System.ComponentModel.ISupportInitialize)(this.webViewWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewWindow;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textUrl;
    }
}
