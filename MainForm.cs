using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webview2_poc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var rawUrl = textUrl.Text;
            Uri uri = null;

            if (Uri.IsWellFormedUriString(rawUrl, UriKind.Absolute))
            {
                uri = new Uri(rawUrl);
            }
            else if (!rawUrl.Contains(" ") && rawUrl.Contains("."))
            {
                uri = new Uri("http://" + rawUrl);
            }
            else
            {
                uri = new Uri("https://google.com/search?q=" +
                    String.Join("+", Uri.EscapeDataString(rawUrl).Split(new string[] { "%20" }, StringSplitOptions.RemoveEmptyEntries)));
            }

            textUrl.Text = uri.ToString();
            webViewWindow.Source = uri;
        }

        private void textUrlEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSubmit_Click(sender, e);
            }
        }

        private async void buttonScreenshot_Click(object sender, EventArgs e)
        {
            var path = @"C:\temp\test.png";

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await webViewWindow.CoreWebView2.CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat.Png, stream);
            }
        }
    }
}
