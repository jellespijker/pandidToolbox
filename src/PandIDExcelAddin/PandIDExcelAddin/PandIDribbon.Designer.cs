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
            this.tabPandID = this.Factory.CreateRibbonTab();
            this.groupProject = this.Factory.CreateRibbonGroup();
            this.dropDownProject = this.Factory.CreateRibbonDropDown();
            this.labelCustomer = this.Factory.CreateRibbonLabel();
            this.labelClass = this.Factory.CreateRibbonLabel();
            this.groupDiagram = this.Factory.CreateRibbonGroup();
            this.dropDownDiagrams = this.Factory.CreateRibbonDropDown();
            this.groupSystem = this.Factory.CreateRibbonGroup();
            this.dropDownFluid = this.Factory.CreateRibbonDropDown();
            this.editBoxTemp = this.Factory.CreateRibbonEditBox();
            this.editBoxPressure = this.Factory.CreateRibbonEditBox();
            this.editBoxMaxVelocity = this.Factory.CreateRibbonEditBox();
            this.groupPipes = this.Factory.CreateRibbonGroup();
            this.dropDownNorm = this.Factory.CreateRibbonDropDown();
            this.dropDownDia = this.Factory.CreateRibbonDropDown();
            this.editBoxLength = this.Factory.CreateRibbonEditBox();
            this.editBoxHeight = this.Factory.CreateRibbonEditBox();
            this.Valves = this.Factory.CreateRibbonGroup();
            this.dropDownType = this.Factory.CreateRibbonDropDown();
            this.dropDownComponent = this.Factory.CreateRibbonDropDown();
            this.buttonAddPipe = this.Factory.CreateRibbonButton();
            this.buttonAddComp = this.Factory.CreateRibbonButton();
            this.tabPandID.SuspendLayout();
            this.groupProject.SuspendLayout();
            this.groupDiagram.SuspendLayout();
            this.groupSystem.SuspendLayout();
            this.groupPipes.SuspendLayout();
            this.Valves.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPandID
            // 
            this.tabPandID.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabPandID.Groups.Add(this.groupProject);
            this.tabPandID.Groups.Add(this.groupDiagram);
            this.tabPandID.Groups.Add(this.groupSystem);
            this.tabPandID.Groups.Add(this.groupPipes);
            this.tabPandID.Groups.Add(this.Valves);
            this.tabPandID.Label = "P&ID Toolbox";
            this.tabPandID.Name = "tabPandID";
            // 
            // groupProject
            // 
            this.groupProject.Items.Add(this.dropDownProject);
            this.groupProject.Items.Add(this.labelCustomer);
            this.groupProject.Items.Add(this.labelClass);
            this.groupProject.Label = "Project";
            this.groupProject.Name = "groupProject";
            // 
            // dropDownProject
            // 
            this.dropDownProject.Label = "Project";
            this.dropDownProject.Name = "dropDownProject";
            this.dropDownProject.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dropDownProject_SelectionChanged);
            // 
            // labelCustomer
            // 
            this.labelCustomer.Label = "Customer";
            this.labelCustomer.Name = "labelCustomer";
            // 
            // labelClass
            // 
            this.labelClass.Label = "Classification Soc.";
            this.labelClass.Name = "labelClass";
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
            this.dropDownDiagrams.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dropDownDiagrams_SelectionChanged);
            // 
            // groupSystem
            // 
            this.groupSystem.Items.Add(this.dropDownFluid);
            this.groupSystem.Items.Add(this.editBoxTemp);
            this.groupSystem.Items.Add(this.editBoxPressure);
            this.groupSystem.Items.Add(this.editBoxMaxVelocity);
            this.groupSystem.Label = "System";
            this.groupSystem.Name = "groupSystem";
            // 
            // dropDownFluid
            // 
            this.dropDownFluid.Label = "Fluid";
            this.dropDownFluid.Name = "dropDownFluid";
            // 
            // editBoxTemp
            // 
            this.editBoxTemp.Label = "Temperature";
            this.editBoxTemp.Name = "editBoxTemp";
            this.editBoxTemp.Text = null;
            // 
            // editBoxPressure
            // 
            this.editBoxPressure.Label = "Pressure";
            this.editBoxPressure.Name = "editBoxPressure";
            this.editBoxPressure.Text = null;
            // 
            // editBoxMaxVelocity
            // 
            this.editBoxMaxVelocity.Label = "Max. Velocity";
            this.editBoxMaxVelocity.Name = "editBoxMaxVelocity";
            this.editBoxMaxVelocity.Text = null;
            // 
            // groupPipes
            // 
            this.groupPipes.Items.Add(this.dropDownNorm);
            this.groupPipes.Items.Add(this.dropDownDia);
            this.groupPipes.Items.Add(this.editBoxLength);
            this.groupPipes.Items.Add(this.editBoxHeight);
            this.groupPipes.Items.Add(this.buttonAddPipe);
            this.groupPipes.Label = "Pipes";
            this.groupPipes.Name = "groupPipes";
            // 
            // dropDownNorm
            // 
            this.dropDownNorm.Label = "C-Norm";
            this.dropDownNorm.Name = "dropDownNorm";
            this.dropDownNorm.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dropDownNorm_SelectionChanged);
            // 
            // dropDownDia
            // 
            this.dropDownDia.Label = "DN";
            this.dropDownDia.Name = "dropDownDia";
            // 
            // editBoxLength
            // 
            this.editBoxLength.Label = "Length";
            this.editBoxLength.Name = "editBoxLength";
            this.editBoxLength.Text = "1";
            // 
            // editBoxHeight
            // 
            this.editBoxHeight.Label = "Height";
            this.editBoxHeight.Name = "editBoxHeight";
            this.editBoxHeight.ScreenTip = "Enter the difference in height between the start of the pipe and the end of the p" +
    "ipe. Possitive means up. Units are in [m]";
            this.editBoxHeight.Text = "0";
            // 
            // Valves
            // 
            this.Valves.Items.Add(this.dropDownType);
            this.Valves.Items.Add(this.dropDownComponent);
            this.Valves.Items.Add(this.buttonAddComp);
            this.Valves.Label = "Valves";
            this.Valves.Name = "Valves";
            // 
            // dropDownType
            // 
            this.dropDownType.Label = "Component type";
            this.dropDownType.Name = "dropDownType";
            this.dropDownType.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dropDownType_SelectionChanged);
            // 
            // dropDownComponent
            // 
            this.dropDownComponent.Label = "Component";
            this.dropDownComponent.Name = "dropDownComponent";
            // 
            // buttonAddPipe
            // 
            this.buttonAddPipe.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonAddPipe.Image = global::PandIDExcelAddin.Properties.Resources.pipe;
            this.buttonAddPipe.Label = "Add pipe";
            this.buttonAddPipe.Name = "buttonAddPipe";
            this.buttonAddPipe.ShowImage = true;
            this.buttonAddPipe.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonAddPipe_Click);
            // 
            // buttonAddComp
            // 
            this.buttonAddComp.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonAddComp.Image = global::PandIDExcelAddin.Properties.Resources.valve;
            this.buttonAddComp.Label = "Add component";
            this.buttonAddComp.Name = "buttonAddComp";
            this.buttonAddComp.ShowImage = true;
            // 
            // PandIDribbon
            // 
            this.Name = "PandIDribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabPandID);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.PandIDribbon_Load);
            this.tabPandID.ResumeLayout(false);
            this.tabPandID.PerformLayout();
            this.groupProject.ResumeLayout(false);
            this.groupProject.PerformLayout();
            this.groupDiagram.ResumeLayout(false);
            this.groupDiagram.PerformLayout();
            this.groupSystem.ResumeLayout(false);
            this.groupSystem.PerformLayout();
            this.groupPipes.ResumeLayout(false);
            this.groupPipes.PerformLayout();
            this.Valves.ResumeLayout(false);
            this.Valves.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabPandID;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupProject;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupDiagram;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownProject;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownDiagrams;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupSystem;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownFluid;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBoxTemp;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBoxPressure;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupPipes;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownNorm;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownDia;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBoxLength;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonAddPipe;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel labelCustomer;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel labelClass;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBoxMaxVelocity;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Valves;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonAddComp;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownType;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownComponent;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBoxHeight;
    }

    partial class ThisRibbonCollection
    {
        internal PandIDribbon PandIDribbon
        {
            get { return this.GetRibbon<PandIDribbon>(); }
        }
    }
}
