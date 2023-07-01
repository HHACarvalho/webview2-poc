using Microsoft.Office.Core;
using Shared;
using System.IO;

namespace PowerPoint
{
    internal class PowerPointService : SharedService
    {
        public override void AddImage(string imagePath)
        {
            var currentSlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            currentSlide.Shapes.AddPicture(imagePath, MsoTriState.msoTrue, MsoTriState.msoTrue, 0, 0);
            File.Delete(imagePath);
        }
    }
}
