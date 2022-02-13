
namespace Polyclinic
{
    partial class PatientPersonalInfo
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
            this.gcIllnessCertificate = new DevExpress.XtraGrid.GridControl();
            this.bsIllnessCertificates = new System.Windows.Forms.BindingSource(this.components);
            this.gvIllnessCertificate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstVisit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastVisit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoctorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueDoctor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsDoctors = new System.Windows.Forms.BindingSource(this.components);
            this.colDiseaseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueDiseases = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsDiseases = new System.Windows.Forms.BindingSource(this.components);
            this.vgcPatientPersonalInfo = new DevExpress.XtraVerticalGrid.VGridControl();
            this.bsPatient = new System.Windows.Forms.BindingSource(this.components);
            this.rilueAddresses = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsAddresses = new System.Windows.Forms.BindingSource(this.components);
            this.rFullName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rEmail = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rBirthDate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rAddress = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcIllnessCertificate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIllnessCertificates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIllnessCertificate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueDiseases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiseases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vgcPatientPersonalInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcIllnessCertificate);
            this.layoutControl1.Controls.Add(this.vgcPatientPersonalInfo);
            this.layoutControl1.Controls.Add(this.sbSave);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(735, 509);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcIllnessCertificate
            // 
            this.gcIllnessCertificate.DataSource = this.bsIllnessCertificates;
            this.gcIllnessCertificate.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcIllnessCertificate.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcIllnessCertificate.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcIllnessCertificate.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gcIllnessCertificate.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcIllnessCertificate.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gcIllnessCertificate.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gcIllnessCertificate.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcIllnessCertificate.Location = new System.Drawing.Point(12, 162);
            this.gcIllnessCertificate.MainView = this.gvIllnessCertificate;
            this.gcIllnessCertificate.Name = "gcIllnessCertificate";
            this.gcIllnessCertificate.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueDoctor,
            this.rilueDiseases});
            this.gcIllnessCertificate.Size = new System.Drawing.Size(711, 335);
            this.gcIllnessCertificate.TabIndex = 6;
            this.gcIllnessCertificate.UseEmbeddedNavigator = true;
            this.gcIllnessCertificate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIllnessCertificate});
            // 
            // bsIllnessCertificates
            // 
            this.bsIllnessCertificates.DataSource = typeof(Models.Classes.IllnessCertificate);
            // 
            // gvIllnessCertificate
            // 
            this.gvIllnessCertificate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstVisit,
            this.colLastVisit,
            this.colDoctorId,
            this.colDiseaseId});
            this.gvIllnessCertificate.GridControl = this.gcIllnessCertificate;
            this.gvIllnessCertificate.Name = "gvIllnessCertificate";
            this.gvIllnessCertificate.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvIllnessCertificate_ValidateRow);
            this.gvIllnessCertificate.DoubleClick += new System.EventHandler(this.gvIllnessCertificate_DoubleClick);
            // 
            // colFirstVisit
            // 
            this.colFirstVisit.Caption = "First Visit";
            this.colFirstVisit.FieldName = "FirstVisit";
            this.colFirstVisit.MinWidth = 25;
            this.colFirstVisit.Name = "colFirstVisit";
            this.colFirstVisit.Visible = true;
            this.colFirstVisit.VisibleIndex = 0;
            this.colFirstVisit.Width = 94;
            // 
            // colLastVisit
            // 
            this.colLastVisit.FieldName = "LastVisit";
            this.colLastVisit.MinWidth = 25;
            this.colLastVisit.Name = "colLastVisit";
            this.colLastVisit.Visible = true;
            this.colLastVisit.VisibleIndex = 1;
            this.colLastVisit.Width = 94;
            // 
            // colDoctorId
            // 
            this.colDoctorId.Caption = "Doctor";
            this.colDoctorId.ColumnEdit = this.rilueDoctor;
            this.colDoctorId.FieldName = "DoctorId";
            this.colDoctorId.MinWidth = 25;
            this.colDoctorId.Name = "colDoctorId";
            this.colDoctorId.Visible = true;
            this.colDoctorId.VisibleIndex = 2;
            this.colDoctorId.Width = 94;
            // 
            // rilueDoctor
            // 
            this.rilueDoctor.AutoHeight = false;
            this.rilueDoctor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueDoctor.DataSource = this.bsDoctors;
            this.rilueDoctor.DisplayMember = "FullName";
            this.rilueDoctor.KeyMember = "Id";
            this.rilueDoctor.Name = "rilueDoctor";
            this.rilueDoctor.ValueMember = "Id";
            // 
            // bsDoctors
            // 
            this.bsDoctors.DataSource = typeof(Models.Classes.Doctor);
            // 
            // colDiseaseId
            // 
            this.colDiseaseId.Caption = "Disease";
            this.colDiseaseId.ColumnEdit = this.rilueDiseases;
            this.colDiseaseId.FieldName = "DiseaseId";
            this.colDiseaseId.MinWidth = 25;
            this.colDiseaseId.Name = "colDiseaseId";
            this.colDiseaseId.Visible = true;
            this.colDiseaseId.VisibleIndex = 3;
            this.colDiseaseId.Width = 94;
            // 
            // rilueDiseases
            // 
            this.rilueDiseases.AutoHeight = false;
            this.rilueDiseases.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueDiseases.DataSource = this.bsDiseases;
            this.rilueDiseases.DisplayMember = "Name";
            this.rilueDiseases.KeyMember = "Id";
            this.rilueDiseases.Name = "rilueDiseases";
            this.rilueDiseases.ValueMember = "Id";
            // 
            // bsDiseases
            // 
            this.bsDiseases.DataSource = typeof(Models.Classes.Disease);
            // 
            // vgcPatientPersonalInfo
            // 
            this.vgcPatientPersonalInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.vgcPatientPersonalInfo.DataSource = this.bsPatient;
            this.vgcPatientPersonalInfo.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vgcPatientPersonalInfo.Location = new System.Drawing.Point(12, 31);
            this.vgcPatientPersonalInfo.Name = "vgcPatientPersonalInfo";
            this.vgcPatientPersonalInfo.RecordWidth = 176;
            this.vgcPatientPersonalInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueAddresses});
            this.vgcPatientPersonalInfo.RowHeaderWidth = 24;
            this.vgcPatientPersonalInfo.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rFullName,
            this.rEmail,
            this.rBirthDate,
            this.rAddress});
            this.vgcPatientPersonalInfo.Size = new System.Drawing.Size(711, 96);
            this.vgcPatientPersonalInfo.TabIndex = 4;
            // 
            // bsPatient
            // 
            this.bsPatient.DataSource = typeof(Models.Classes.Patient);
            // 
            // rilueAddresses
            // 
            this.rilueAddresses.AutoHeight = false;
            this.rilueAddresses.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueAddresses.DataSource = this.bsAddresses;
            this.rilueAddresses.DisplayMember = "Address";
            this.rilueAddresses.KeyMember = "AddressId";
            this.rilueAddresses.Name = "rilueAddresses";
            this.rilueAddresses.ValueMember = "AddressId";
            // 
            // bsAddresses
            // 
            this.bsAddresses.DataSource = typeof(Models.Classes.AddressAsString);
            // 
            // rFullName
            // 
            this.rFullName.Name = "rFullName";
            this.rFullName.Properties.Caption = "Full Name";
            this.rFullName.Properties.FieldName = "FullName";
            // 
            // rEmail
            // 
            this.rEmail.Name = "rEmail";
            this.rEmail.Properties.Caption = "Email";
            this.rEmail.Properties.FieldName = "Email";
            // 
            // rBirthDate
            // 
            this.rBirthDate.Name = "rBirthDate";
            this.rBirthDate.Properties.Caption = "Birth Date";
            this.rBirthDate.Properties.FieldName = "BirthDate";
            // 
            // rAddress
            // 
            this.rAddress.Name = "rAddress";
            this.rAddress.Properties.Caption = "Address";
            this.rAddress.Properties.FieldName = "AddressId";
            this.rAddress.Properties.RowEdit = this.rilueAddresses;
            // 
            // sbSave
            // 
            this.sbSave.Location = new System.Drawing.Point(12, 131);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(711, 27);
            this.sbSave.StyleController = this.layoutControl1;
            this.sbSave.TabIndex = 5;
            this.sbSave.Text = "Save";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(735, 509);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.vgcPatientPersonalInfo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(715, 119);
            this.layoutControlItem1.Text = "Personal Info";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(715, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcIllnessCertificate;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 150);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(715, 339);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // PatientPersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 509);
            this.Controls.Add(this.layoutControl1);
            this.Name = "PatientPersonalInfo";
            this.Text = "PatientPersonalInfo";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcIllnessCertificate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIllnessCertificates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIllnessCertificate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueDiseases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiseases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vgcPatientPersonalInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraVerticalGrid.VGridControl vgcPatientPersonalInfo;
        private System.Windows.Forms.BindingSource bsPatient;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueAddresses;
        private System.Windows.Forms.BindingSource bsAddresses;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rFullName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rEmail;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rBirthDate;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rAddress;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource bsIllnessCertificates;
        private DevExpress.XtraGrid.GridControl gcIllnessCertificate;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIllnessCertificate;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstVisit;
        private DevExpress.XtraGrid.Columns.GridColumn colLastVisit;
        private DevExpress.XtraGrid.Columns.GridColumn colDoctorId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueDoctor;
        private System.Windows.Forms.BindingSource bsDoctors;
        private DevExpress.XtraGrid.Columns.GridColumn colDiseaseId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueDiseases;
        private System.Windows.Forms.BindingSource bsDiseases;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}