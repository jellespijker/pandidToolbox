namespace PandIDExcelAddin
{
    partial class PandIDribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public PandIDribbon()
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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.groupProject = this.Factory.CreateRibbonGroup();
            this.groupDiagram = this.Factory.CreateRibbonGroup();
            this.dropDownDiagrams = this.Factory.CreateRibbonDropDown();
            this.dropDownProject = this.Factory.CreateRibbonDropDown();
            this.buttonEditProject = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.groupProject.SuspendLayout();
            this.groupDiagram.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.groupProject);
            this.tab1.Groups.Add(this.groupDiagram);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // groupProject
            // 
            this.groupProject.Items.Add(this.dropDownProject);
            this.groupProject.Items.Add(this.buttonEditProject);
            this.groupProject.Label = "Project";
            this.groupProject.Name = "groupProject";
            // 
            // groupDiagram
            // 
            this.groupDiagram.Items.Add(this.dropDownDiagrams);
            this.groupDiagram.Label = "Diagram";
            this.groupDiagram.Name = "groupDiagram";
            // 
            // dropDownDiagrams
            // 
            this.dropDownDiagrams.Label = "Diagrams";
            this.dropDownDiagrams.Name = "dropDownDiagrams";
            // 
            // dropDownProject
            // 
            this.dropDownProject.Label = "Project";
            this.dropDownProject.Name = "dropDownProject";
            // 
            // buttonEditProject
            // 
            this.buttonEditProject.Label = "Edit Project";
            this.buttonEditProject.Name = "buttonEditProject";
            // 
            // PandIDribbon
            // 
            this.Name = "PandIDribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.PandIDribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.groupProject.ResumeLayout(false);
            this.groupProject.PerformLayout();
            this.groupDiagram.ResumeLayout(false);
            this.groupDiagram.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupProject;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupDiagram;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownProject;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonEditProject;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownDiagrams;
    }

    partial class ThisRibbonCollection
    {
        internal PandIDribbon PandIDribbon
        {
            get { return this.GetRibbon<PandIDribbon>(); }
        }
    }
}
