
namespace Polyclinic
{
    partial class NoteIllnessCertificate
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
            this.gcNotes = new DevExpress.XtraGrid.GridControl();
            this.gvNotes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsNotes = new System.Windows.Forms.BindingSource(this.components);
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcNotes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(857, 409);
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
            this.Root.Size = new System.Drawing.Size(857, 409);
            this.Root.TextVisible = false;
            // 
            // gcNotes
            // 
            this.gcNotes.DataSource = this.bsNotes;
            this.gcNotes.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcNotes.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcNotes.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcNotes.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gcNotes.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcNotes.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gcNotes.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gcNotes.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcNotes.Location = new System.Drawing.Point(12, 12);
            this.gcNotes.MainView = this.gvNotes;
            this.gcNotes.Name = "gcNotes";
            this.gcNotes.Size = new System.Drawing.Size(833, 385);
            this.gcNotes.TabIndex = 4;
            this.gcNotes.UseEmbeddedNavigator = true;
            this.gcNotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNotes});
            // 
            // gvNotes
            // 
            this.gvNotes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNote,
            this.colDate});
            this.gvNotes.GridControl = this.gcNotes;
            this.gvNotes.Name = "gvNotes";
            this.gvNotes.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvNotes_ValidateRow);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcNotes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(837, 389);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // bsNotes
            // 
            this.bsNotes.DataSource = typeof(Models.Classes.NoteIllnessCertificate);
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 25;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 1;
            this.colNote.Width = 94;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 25;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 2;
            this.colDate.Width = 94;
            // 
            // NoteIllnessCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 409);
            this.Controls.Add(this.layoutControl1);
            this.Name = "NoteIllnessCertificate";
            this.Text = "NoteIllnessCertificate";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcNotes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNotes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bsNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
    }
}