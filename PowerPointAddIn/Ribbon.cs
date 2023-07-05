using Microsoft.Office.Core;
using Microsoft.Office.Tools.Ribbon;
using Common;
using System;
using System.IO;

namespace PowerPoint
{
    public partial class Ribbon
    {
        private MainForm mainForm;

        private void Ribbon_Load(object sender, RibbonUIEventArgs e) { }

        private void ButtonLaunchApp_Click(object sender, RibbonControlEventArgs e)
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
            AddImageToPresentation(imagePath);
        }

        private async void MainForm_screenshotOffscreenTaken(object sender, EventArgs e)
        {
            var imagePath = await mainForm.SaveScreenshot(true);
            AddImageToPresentation(imagePath);
        }

        private void AddImageToPresentation(string imagePath)
        {
            var currentSlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            currentSlide.Shapes.AddPicture(imagePath, MsoTriState.msoTrue, MsoTriState.msoTrue, 0, 0);
            File.Delete(imagePath);
        }
    }
}
