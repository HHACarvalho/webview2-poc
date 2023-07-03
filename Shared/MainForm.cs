using Microsoft.Web.WebView2.Core;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared
{
    public partial class MainForm : Form
    {
        public event EventHandler FormClose;
        public event EventHandler ScreenshotTaken;
        public event EventHandler ScreenshotOffscreenTaken;

        private TaskCompletionSource<bool> tsc;

        private readonly string rootPath = @"C:\temp\";
        private readonly string webViewStartUrl = "https://www.google.com/";
        private readonly string webViewOffscreenStartUrl = "https://www.youtube.com/";

        public MainForm()
        {
            InitializeComponent();
            InitializeAsync();
        }

        async void InitializeAsync()
        {
            var webView2Environment = await CoreWebView2Environment.CreateAsync(null, rootPath);

            await webViewMain.EnsureCoreWebView2Async(webView2Environment);
            await webViewOffscreen.EnsureCoreWebView2Async(webView2Environment);

            webViewMain.Source = new Uri(webViewStartUrl);
            webViewOffscreen.Source = new Uri(webViewOffscreenStartUrl);
        }

        /*
         * Events
         */

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            Uri uri = GetValidUri(textBoxUrl.Text);
            textBoxUrl.Text = uri.ToString();
            webViewMain.Source = uri;
        }

        private void TextBoxUrl_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonGo_Click(sender, EventArgs.Empty);
            }
        }

        private void ButtonScreenshot_Click(object sender, EventArgs e)
        {
            ScreenshotTaken?.Invoke(this, EventArgs.Empty);
        }

        private void WebView_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            textBoxUrl.Text = webViewMain.Source.AbsoluteUri;
        }

        private void TextBoxUrlOffscreen_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonScreenshotOffscreen_Click(sender, EventArgs.Empty);
            }
        }

        private async void ButtonScreenshotOffscreen_Click(object sender, EventArgs e)
        {
            Uri uri = GetValidUri(textBoxUrlOffscreen.Text);

            if (uri.ToString() != textBoxUrlOffscreen.Text)
            {
                textBoxUrlOffscreen.Text = uri.ToString();
                webViewOffscreen.Source = uri;

                tsc = new TaskCompletionSource<bool>();
                await tsc.Task;
            }

            ScreenshotOffscreenTaken?.Invoke(this, EventArgs.Empty);
        }

        private void WebviewOffscreen_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            tsc?.TrySetResult(true);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClose?.Invoke(this, EventArgs.Empty);
        }

        /*
         * Private Methods
         */

        /// <summary>
        /// Given a string returns a valid URI.
        /// </summary>
        /// <param name="rawUrl">The URL or seach query in string form.</param>
        /// <returns>Returns a valid URI if the string provided was either valid or incomplete. Returns a google search result otherwise.</returns>
        
        private Uri GetValidUri(string rawUrl)
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

        /// <summary>
        /// Captures a screenshot from a WebView2 component and saves it to png file with an unique name.
        /// </summary>
        /// <param name="offscreen">Controls which WebView2 component is used to capture the screenshot. If true the offscreen one is used.</param>
        /// <returns>A path to the saved image file.</returns>
        public async Task<string> SaveScreenshot(bool offscreen)
        {
            var path = rootPath + Guid.NewGuid().ToString() + ".png";

            using (var stream = new FileStream(path, FileMode.Create))
            {
                if (offscreen)
                {
                    await webViewOffscreen.CoreWebView2.CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat.Png, stream);
                }
                else
                {
                    await webViewMain.CoreWebView2.CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat.Png, stream);
                }
            }

            return path;
        }
    }
}
