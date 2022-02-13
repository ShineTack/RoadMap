
namespace Polyclinic
{
    partial class Disease
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvDiseaseType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDiseaseType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDiseaseTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDisease = new DevExpress.XtraGrid.GridControl();
            this.bsDiseaseType = new System.Windows.Forms.BindingSource(this.components);
            this.gvDisease = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueDiseaseType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcDiseaseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsDisease = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvDiseaseType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDisease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiseaseType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDisease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueDiseaseType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDisease)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDiseaseType
            // 
            this.gvDiseaseType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcDiseaseType,
            this.gcDiseaseTypeId});
            this.gvDiseaseType.GridControl = this.gcDisease;
            this.gvDiseaseType.Name = "gvDiseaseType";
            this.gvDiseaseType.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvDiseaseType_ValidateRow);
            // 
            // gcDiseaseType
            // 
            this.gcDiseaseType.Caption = "Disease Type";
            this.gcDiseaseType.FieldName = "Type";
            this.gcDiseaseType.MinWidth = 25;
            this.gcDiseaseType.Name = "gcDiseaseType";
            this.gcDiseaseType.Visible = true;
            this.gcDiseaseType.VisibleIndex = 0;
            this.gcDiseaseType.Width = 94;
            // 
            // gcDiseaseTypeId
            // 
            this.gcDiseaseTypeId.Caption = "DiseaseTypeId";
            this.gcDiseaseTypeId.FieldName = "Id";
            this.gcDiseaseTypeId.MinWidth = 25;
            this.gcDiseaseTypeId.Name = "gcDiseaseTypeId";
            this.gcDiseaseTypeId.Width = 94;
            // 
            // gcDisease
            // 
            this.gcDisease.DataSource = this.bsDiseaseType;
            this.gcDisease.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcDisease.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcDisease.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcDisease.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gcDisease.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcDisease.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gcDisease.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gcDisease.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridLevelNode2.LevelTemplate = this.gvDiseaseType;
            gridLevelNode2.RelationName = "Level1";
            this.gcDisease.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gcDisease.Location = new System.Drawing.Point(12, 12);
            this.gcDisease.MainView = this.gvDisease;
            this.gcDisease.Name = "gcDisease";
            this.gcDisease.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueDiseaseType});
            this.gcDisease.Size = new System.Drawing.Size(521, 556);
            this.gcDisease.TabIndex = 4;
            this.gcDisease.UseEmbeddedNavigator = true;
            this.gcDisease.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDisease,
            this.gvDiseaseType});
            // 
            // bsDiseaseType
            // 
            this.bsDiseaseType.DataSource = typeof(Models.Classes.DiseaseType);
            // 
            // gvDisease
            // 
            this.gvDisease.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcName,
            this.gcType,
            this.gcDiseaseId});
            this.gvDisease.GridControl = this.gcDisease;
            this.gvDisease.Name = "gvDisease";
            this.gvDisease.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvDisease_ValidateRow);
            // 
            // gcName
            // 
            this.gcName.Caption = "Disease Name";
            this.gcName.FieldName = "Name";
            this.gcName.MinWidth = 25;
            this.gcName.Name = "gcName";
            this.gcName.Visible = true;
            this.gcName.VisibleIndex = 0;
            this.gcName.Width = 94;
            // 
            // gcType
            // 
            this.gcType.Caption = "Disease Type";
            this.gcType.ColumnEdit = this.rilueDiseaseType;
            this.gcType.FieldName = "DiseaseTypeId";
            this.gcType.MinWidth = 25;
            this.gcType.Name = "gcType";
            this.gcType.Visible = true;
            this.gcType.VisibleIndex = 1;
            this.gcType.Width = 94;
            // 
            // rilueDiseaseType
            // 
            this.rilueDiseaseType.AutoHeight = false;
            this.rilueDiseaseType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueDiseaseType.DataSource = this.bsDiseaseType;
            this.rilueDiseaseType.DisplayMember = "Type";
            this.rilueDiseaseType.KeyMember = "Id";
            this.rilueDiseaseType.Name = "rilueDiseaseType";
            this.rilueDiseaseType.ValueMember = "Id";
            // 
            // gcDiseaseId
            // 
            this.gcDiseaseId.Caption = "Id";
            this.gcDiseaseId.FieldName = "Id";
            this.gcDiseaseId.MinWidth = 25;
            this.gcDiseaseId.Name = "gcDiseaseId";
            this.gcDiseaseId.Width = 94;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcDisease);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(545, 580);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(545, 580);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcDisease;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(525, 560);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Disease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 580);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Disease";
            this.Text = "Disease";
            ((System.ComponentModel.ISupportInitialize)(this.gvDiseaseType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDisease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiseaseType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDisease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueDiseaseType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDisease)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcDisease;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDisease;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiseaseType;
        private DevExpress.XtraGrid.Columns.GridColumn gcDiseaseType;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueDiseaseType;
        private System.Windows.Forms.BindingSource bsDiseaseType;
        private DevExpress.XtraGrid.Columns.GridColumn gcDiseaseTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn gcDiseaseId;
        private System.Windows.Forms.BindingSource bsDisease;
    }
}