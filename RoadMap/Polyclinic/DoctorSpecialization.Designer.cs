
namespace Polyclinic
{
    partial class DoctorSpecialization
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gcDoctorSpecialization = new DevExpress.XtraGrid.GridControl();
            this.gvDoctorSpecialization = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcSpecialization = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsDoctorSpecialization = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDoctorSpecialization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctorSpecialization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoctorSpecialization)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcDoctorSpecialization);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(298, 570);
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
            this.Root.Size = new System.Drawing.Size(298, 570);
            this.Root.TextVisible = false;
            // 
            // gcDoctorSpecialization
            // 
            this.gcDoctorSpecialization.DataSource = this.bsDoctorSpecialization;
            this.gcDoctorSpecialization.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcDoctorSpecialization.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcDoctorSpecialization.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcDoctorSpecialization.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gcDoctorSpecialization.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcDoctorSpecialization.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gcDoctorSpecialization.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gcDoctorSpecialization.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcDoctorSpecialization.Location = new System.Drawing.Point(12, 12);
            this.gcDoctorSpecialization.MainView = this.gvDoctorSpecialization;
            this.gcDoctorSpecialization.Name = "gcDoctorSpecialization";
            this.gcDoctorSpecialization.Size = new System.Drawing.Size(274, 546);
            this.gcDoctorSpecialization.TabIndex = 4;
            this.gcDoctorSpecialization.UseEmbeddedNavigator = true;
            this.gcDoctorSpecialization.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDoctorSpecialization});
            // 
            // gvDoctorSpecialization
            // 
            this.gvDoctorSpecialization.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcSpecialization});
            this.gvDoctorSpecialization.GridControl = this.gcDoctorSpecialization;
            this.gvDoctorSpecialization.Name = "gvDoctorSpecialization";
            this.gvDoctorSpecialization.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvDoctorSpecialization_ValidateRow);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcDoctorSpecialization;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(278, 550);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // gcSpecialization
            // 
            this.gcSpecialization.Caption = "Specialization";
            this.gcSpecialization.FieldName = "Name";
            this.gcSpecialization.MinWidth = 25;
            this.gcSpecialization.Name = "gcSpecialization";
            this.gcSpecialization.Visible = true;
            this.gcSpecialization.VisibleIndex = 0;
            this.gcSpecialization.Width = 94;
            // 
            // bsDoctorSpecialization
            // 
            this.bsDoctorSpecialization.DataSource = typeof(Models.Classes.DoctorSpecialization);
            // 
            // DoctorSpecialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 570);
            this.Controls.Add(this.layoutControl1);
            this.Name = "DoctorSpecialization";
            this.Text = "DoctorSpecialization";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDoctorSpecialization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctorSpecialization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoctorSpecialization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcDoctorSpecialization;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDoctorSpecialization;
        private DevExpress.XtraGrid.Columns.GridColumn gcSpecialization;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bsDoctorSpecialization;
    }
}