using Microsoft.Office.Tools.Ribbon;
using Shared;

namespace PowerPoint
{
    public partial class Ribbon
    {
        MainForm mainForm;

        private void Ribbon_Load(object sender, RibbonUIEventArgs e) { }

        private void buttonLaunchApp_Click(object sender, RibbonControlEventArgs e)
        {
            mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
