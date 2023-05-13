using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webview2_poc
{
    public partial class MainForm : Form
    {
        TaskCompletionSource<bool> tsc;

        public MainForm()
        {
            InitializeComponent();
        }

        /*
        * Events
        */

        private void buttonGo_Click(object sender, EventArgs e)
        {
            Uri uri = getUri(textUrl.Text);
            textUrl.Text = uri.ToString();
            mainWebView.Source = uri;
        }

        private void textUrlEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonGo_Click(sender, e);
            }
        }

        private void buttonScreenshot_Click(object sender, EventArgs e)
        {
            saveScreenshot(mainWebView, @"C:\temp\test.png");
        }

        private async void buttonScreenshotOffscreen_Click(object sender, EventArgs e)
        {
            Uri uri = getUri(textUrlOffscreen.Text);

            if (uri.ToString() != textUrlOffscreen.Text)
            {
                textUrlOffscreen.Text = uri.ToString();
                offscreenWebView.Source = uri;

                tsc = new TaskCompletionSource<bool>();
                await tsc.Task;
            }

            saveScreenshot(offscreenWebView, @"C:\temp\testSec.png");
        }

        private void requestScreenshot(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            tsc?.TrySetResult(true);
        }

        /*
         * Private methods
         */

        private Uri getUri(string rawUrl)
        {
            if (Uri.IsWellFormedUriString(rawUrl, UriKind.Absolute))
            {
                return new Uri(rawUrl);
            }
            else if (!rawUrl.Contains(" ") && rawUrl.Contains("."))
            {
                return new Uri("https://" + rawUrl);
            }
            else
            {
                return new Uri("https://google.com/search?q=" +
                    string.Join("+", Uri.EscapeDataString(rawUrl).Split(new string[] { "%20" }, StringSplitOptions.RemoveEmptyEntries)));
            }
        }

        private async void saveScreenshot(WebView2 wbWindow, string path)
        {
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await wbWindow.CoreWebView2.CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat.Png, stream);
            }
        }
    }
}
