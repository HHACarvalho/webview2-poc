namespace PowerPoint
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabVSTO = this.Factory.CreateRibbonTab();
            this.groupGeneral = this.Factory.CreateRibbonGroup();
            this.buttonLaunchApp = this.Factory.CreateRibbonButton();
            this.tabVSTO.SuspendLayout();
            this.groupGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabVSTO
            // 
            this.tabVSTO.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabVSTO.Groups.Add(this.groupGeneral);
            this.tabVSTO.Label = "VSTO";
            this.tabVSTO.Name = "tabVSTO";
            // 
            // groupGeneral
            // 
            this.groupGeneral.Items.Add(this.buttonLaunchApp);
            this.groupGeneral.Label = "General";
            this.groupGeneral.Name = "groupGeneral";
            // 
            // buttonLaunchApp
            // 
            this.buttonLaunchApp.Label = "Launch App";
            this.buttonLaunchApp.Name = "buttonLaunchApp";
            this.buttonLaunchApp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonLaunchApp_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tabVSTO);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tabVSTO.ResumeLayout(false);
            this.tabVSTO.PerformLayout();
            this.groupGeneral.ResumeLayout(false);
            this.groupGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabVSTO;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupGeneral;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonLaunchApp;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
