
namespace Polyclinic
{
    partial class Persons
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcPersons = new DevExpress.XtraGrid.GridControl();
            this.gvDoctors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvPatients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmsPersons = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.bsPersons = new System.Windows.Forms.BindingSource(this.components);
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.cmsPersons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcPersons);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(937, 590);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcPersons
            // 
            this.gcPersons.ContextMenuStrip = this.cmsPersons;
            this.gcPersons.Location = new System.Drawing.Point(12, 12);
            this.gcPersons.MainView = this.gvDoctors;
            this.gcPersons.Name = "gcPersons";
            this.gcPersons.Size = new System.Drawing.Size(913, 566);
            this.gcPersons.TabIndex = 4;
            this.gcPersons.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDoctors,
            this.gvPatients});
            // 
            // gvDoctors
            // 
            this.gvDoctors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcFullName,
            this.gcEmail,
            this.gcBirthDate});
            this.gvDoctors.GridControl = this.gcPersons;
            this.gvDoctors.Name = "gvDoctors";
            // 
            // gcFullName
            // 
            this.gcFullName.Caption = "Name";
            this.gcFullName.FieldName = "FullName";
            this.gcFullName.MinWidth = 25;
            this.gcFullName.Name = "gcFullName";
            this.gcFullName.Visible = true;
            this.gcFullName.VisibleIndex = 0;
            this.gcFullName.Width = 94;
            // 
            // gcEmail
            // 
            this.gcEmail.Caption = "Email";
            this.gcEmail.FieldName = "Email";
            this.gcEmail.MinWidth = 25;
            this.gcEmail.Name = "gcEmail";
            this.gcEmail.Visible = true;
            this.gcEmail.VisibleIndex = 1;
            this.gcEmail.Width = 94;
            // 
            // gcBirthDate
            // 
            this.gcBirthDate.Caption = "Birth Date";
            this.gcBirthDate.FieldName = "BirthDate";
            this.gcBirthDate.MinWidth = 25;
            this.gcBirthDate.Name = "gcBirthDate";
            this.gcBirthDate.Visible = true;
            this.gcBirthDate.VisibleIndex = 2;
            this.gcBirthDate.Width = 94;
            // 
            // gvPatients
            // 
            this.gvPatients.GridControl = this.gcPersons;
            this.gvPatients.Name = "gvPatients";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(937, 590);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcPersons;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(917, 570);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // cmsPersons
            // 
            this.cmsPersons.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPersons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddNew,
            this.tsmiUpdate});
            this.cmsPersons.Name = "cmsPersons";
            this.cmsPersons.Size = new System.Drawing.Size(211, 80);
            // 
            // tsmiAddNew
            // 
            this.tsmiAddNew.Name = "tsmiAddNew";
            this.tsmiAddNew.Size = new System.Drawing.Size(210, 24);
            this.tsmiAddNew.Text = "Add New";
            this.tsmiAddNew.Click += new System.EventHandler(this.tsmiAddNew_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(210, 24);
            this.tsmiUpdate.Text = "Update";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // Persons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 590);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Persons";
            this.Text = "Persons";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.cmsPersons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsPersons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcPersons;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDoctors;
        private DevExpress.XtraGrid.Columns.GridColumn gcFullName;
        private DevExpress.XtraGrid.Columns.GridColumn gcEmail;
        private DevExpress.XtraGrid.Columns.GridColumn gcBirthDate;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatients;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.ContextMenuStrip cmsPersons;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNew;
        private System.Windows.Forms.BindingSource bsPersons;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
    }
}