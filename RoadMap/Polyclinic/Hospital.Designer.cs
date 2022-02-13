
namespace Polyclinic
{
    partial class Hospital
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
            this.gcHospital = new DevExpress.XtraGrid.GridControl();
            this.bsHospital = new System.Windows.Forms.BindingSource(this.components);
            this.gvHospital = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcHospitalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pilueAddresses = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsAddresses = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilueAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcHospital);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(477, 559);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcHospital
            // 
            this.gcHospital.DataSource = this.bsHospital;
            this.gcHospital.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcHospital.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcHospital.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcHospital.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gcHospital.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcHospital.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gcHospital.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gcHospital.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcHospital.Location = new System.Drawing.Point(12, 12);
            this.gcHospital.MainView = this.gvHospital;
            this.gcHospital.Name = "gcHospital";
            this.gcHospital.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.pilueAddresses});
            this.gcHospital.Size = new System.Drawing.Size(453, 535);
            this.gcHospital.TabIndex = 4;
            this.gcHospital.UseEmbeddedNavigator = true;
            this.gcHospital.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHospital});
            // 
            // bsHospital
            // 
            this.bsHospital.DataSource = typeof(Models.Classes.Hospital);
            // 
            // gvHospital
            // 
            this.gvHospital.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcHospitalName,
            this.gcAddress});
            this.gvHospital.GridControl = this.gcHospital;
            this.gvHospital.Name = "gvHospital";
            this.gvHospital.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvHospital_ValidateRow);
            // 
            // gcHospitalName
            // 
            this.gcHospitalName.Caption = "Hospital";
            this.gcHospitalName.FieldName = "Name";
            this.gcHospitalName.MinWidth = 25;
            this.gcHospitalName.Name = "gcHospitalName";
            this.gcHospitalName.Visible = true;
            this.gcHospitalName.VisibleIndex = 1;
            this.gcHospitalName.Width = 94;
            // 
            // gcAddress
            // 
            this.gcAddress.Caption = "Address";
            this.gcAddress.ColumnEdit = this.pilueAddresses;
            this.gcAddress.CustomizationCaption = "Address";
            this.gcAddress.FieldName = "AddressId";
            this.gcAddress.MinWidth = 25;
            this.gcAddress.Name = "gcAddress";
            this.gcAddress.Visible = true;
            this.gcAddress.VisibleIndex = 0;
            this.gcAddress.Width = 94;
            // 
            // pilueAddresses
            // 
            this.pilueAddresses.AutoHeight = false;
            this.pilueAddresses.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pilueAddresses.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Address")});
            this.pilueAddresses.DataSource = this.bsAddresses;
            this.pilueAddresses.DisplayMember = "Address";
            this.pilueAddresses.KeyMember = "AddressId";
            this.pilueAddresses.Name = "pilueAddresses";
            this.pilueAddresses.ValueMember = "AddressId";
            // 
            // bsAddresses
            // 
            this.bsAddresses.DataSource = typeof(Models.Classes.AddressAsString);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(477, 559);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcHospital;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(457, 539);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 559);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Hospital";
            this.Text = "Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilueAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcHospital;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHospital;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bsHospital;
        private DevExpress.XtraGrid.Columns.GridColumn gcHospitalName;
        private DevExpress.XtraGrid.Columns.GridColumn gcAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit pilueAddresses;
        private System.Windows.Forms.BindingSource bsAddresses;
    }
}