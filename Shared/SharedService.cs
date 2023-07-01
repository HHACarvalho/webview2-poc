using System;

namespace Shared
{
    public abstract class SharedService
    {
        private MainForm mainForm;

        public void LaunchApp()
        {
            mainForm = new MainForm();
            mainForm.Show();

            mainForm.FormClose += MainForm_formClosed;
            mainForm.ScreenshotTaken += MainForm_screenshotTaken;
            mainForm.ScreenshotOffscreenTaken += MainForm_screenshotOffscreenTaken;
        }

        private void MainForm_formClosed(object sender, EventArgs e)
        {
            mainForm.ScreenshotOffscreenTaken -= MainForm_screenshotOffscreenTaken;
            mainForm.ScreenshotTaken -= MainForm_screenshotTaken;
            mainForm.FormClose -= MainForm_formClosed;

            mainForm = null;
        }

        private async void MainForm_screenshotTaken(object sender, EventArgs e)
        {
            var imagePath = await mainForm.SaveScreenshot(false);
            AddImage(imagePath);
        }

        private async void MainForm_screenshotOffscreenTaken(object sender, EventArgs e)
        {
            var imagePath = await mainForm.SaveScreenshot(true);
            AddImage(imagePath);
        }

        public abstract void AddImage(string imagePath);
    }
}
