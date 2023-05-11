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
            this.mainWV = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.buttonScreenshot = new System.Windows.Forms.Button();
            this.secondaryWV = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.textUrlSec = new System.Windows.Forms.TextBox();
            this.buttonScreenshotSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainWV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondaryWV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainWV
            // 
            this.mainWV.AllowExternalDrop = true;
            this.mainWV.CreationProperties = null;
            this.mainWV.DefaultBackgroundColor = System.Drawing.Color.White;
            this.mainWV.Location = new System.Drawing.Point(12, 41);
            this.mainWV.Name = "mainWV";
            this.mainWV.Size = new System.Drawing.Size(1000, 523);
            this.mainWV.Source = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            this.mainWV.TabIndex = 0;
            this.mainWV.ZoomFactor = 1D;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(12, 12);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonSubmit_Click);
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
            // secondaryWV
            // 
            this.secondaryWV.AllowExternalDrop = true;
            this.secondaryWV.CreationProperties = null;
            this.secondaryWV.DefaultBackgroundColor = System.Drawing.Color.White;
            this.secondaryWV.Location = new System.Drawing.Point(12, 700);
            this.secondaryWV.Name = "secondaryWV";
            this.secondaryWV.Size = new System.Drawing.Size(1000, 523);
            this.secondaryWV.Source = new System.Uri("https://www.youtube.com/", System.UriKind.Absolute);
            this.secondaryWV.TabIndex = 4;
            this.secondaryWV.TabStop = false;
            this.secondaryWV.ZoomFactor = 1D;
            // 
            // textUrlSec
            // 
            this.textUrlSec.Location = new System.Drawing.Point(12, 573);
            this.textUrlSec.Name = "textUrlSec";
            this.textUrlSec.Size = new System.Drawing.Size(918, 20);
            this.textUrlSec.TabIndex = 5;
            this.textUrlSec.Text = "https://www.youtube.com/";
            // 
            // buttonScreenshotSec
            // 
            this.buttonScreenshotSec.Location = new System.Drawing.Point(936, 571);
            this.buttonScreenshotSec.Name = "buttonScreenshotSec";
            this.buttonScreenshotSec.Size = new System.Drawing.Size(75, 23);
            this.buttonScreenshotSec.TabIndex = 6;
            this.buttonScreenshotSec.Text = "Screenshot";
            this.buttonScreenshotSec.UseVisualStyleBackColor = true;
            this.buttonScreenshotSec.Click += new System.EventHandler(this.buttonScreenshotSec_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 606);
            this.Controls.Add(this.buttonScreenshotSec);
            this.Controls.Add(this.textUrlSec);
            this.Controls.Add(this.secondaryWV);
            this.Controls.Add(this.buttonScreenshot);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.mainWV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WebView2 Application";
            ((System.ComponentModel.ISupportInitialize)(this.mainWV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondaryWV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 mainWV;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Button buttonScreenshot;
        private Microsoft.Web.WebView2.WinForms.WebView2 secondaryWV;
        private System.Windows.Forms.TextBox textUrlSec;
        private System.Windows.Forms.Button buttonScreenshotSec;
    }
}
