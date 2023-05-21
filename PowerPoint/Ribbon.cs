using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerPoint
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void buttonLaunchApp_Click(object sender, RibbonControlEventArgs e)
        {
            Console.WriteLine("Hello!");
        }
    }
}
