using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared
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
            Uri uri = getValidUri(textBoxUrl.Text);
            textBoxUrl.Text = uri.ToString();
            webView.Source = uri;
        }

        private void textBoxUrl_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonGo_Click(sender, e);
            }
        }

        private void buttonScreenshot_Click(object sender, EventArgs e)
        {
            saveScreenshot(webView, @"C:\temp\" + fileNameCount() + ".png");
        }

        private void textBoxUrlOffscreen_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonScreenshotOffscreen_Click(sender, e);
            }
        }

        private async void buttonScreenshotOffscreen_Click(object sender, EventArgs e)
        {
            Uri uri = getValidUri(textBoxUrlOffscreen.Text);

            if (uri.ToString() != textBoxUrlOffscreen.Text)
            {
                textBoxUrlOffscreen.Text = uri.ToString();
                webViewOffscreen.Source = uri;

                tsc = new TaskCompletionSource<bool>();
                await tsc.Task;
            }

            saveScreenshot(webViewOffscreen, @"C:\temp\offscreen_" + fileNameCount() + ".png");
        }

        private void webviewOffscreen_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            tsc?.TrySetResult(true);
        }

        /*
         * Private Methods
         */

        private Uri getValidUri(string rawUrl)
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
                return new Uri("https://google.com/search?q=" + string.Join("+", Uri.EscapeDataString(rawUrl).Split(new string[] { "%20" }, StringSplitOptions.RemoveEmptyEntries)));
            }
        }

        private async void saveScreenshot(WebView2 wbWindow, string path)
        {
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await wbWindow.CoreWebView2.CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat.Png, stream);
            }
        }

        private string fileNameCount()
        {
            return "IMG_" + Directory.GetFiles(@"C:\temp", "*", SearchOption.TopDirectoryOnly).Length.ToString().PadLeft(5, '0');
        }
    }
}
