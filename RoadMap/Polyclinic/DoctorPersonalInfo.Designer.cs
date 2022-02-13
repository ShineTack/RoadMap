
namespace Polyclinic
{
    partial class DoctorPersonalInfo
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
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rFullName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rEmail = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rBirthDate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.vGridControl2 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rAddress = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rilueAddress = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsDoctor = new System.Windows.Forms.BindingSource(this.components);
            this.bsAddress = new System.Windows.Forms.BindingSource(this.components);
            this.rSpecializationId = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rHospitalId = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rilueSpecialization = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rilueHospital = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsSpecialization = new System.Windows.Forms.BindingSource(this.components);
            this.bsHospital = new System.Windows.Forms.BindingSource(this.components);
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueSpecialization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpecialization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.vGridControl2);
            this.layoutControl1.Controls.Add(this.vGridControl1);
            this.layoutControl1.Controls.Add(this.sbSave);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(925, 244);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
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
            this.Root.Size = new System.Drawing.Size(925, 244);
            this.Root.TextVisible = false;
            // 
            // vGridControl1
            // 
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl1.DataSource = this.bsDoctor;
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(12, 31);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 179;
            this.vGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueAddress});
            this.vGridControl1.RowHeaderWidth = 21;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rFullName,
            this.rEmail,
            this.rBirthDate,
            this.rAddress});
            this.vGridControl1.Size = new System.Drawing.Size(901, 96);
            this.vGridControl1.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.vGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(905, 119);
            this.layoutControlItem1.Text = "PeronalInfo";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 16);
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
            // vGridControl2
            // 
            this.vGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl2.DataSource = this.bsDoctor;
            this.vGridControl2.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl2.Location = new System.Drawing.Point(12, 150);
            this.vGridControl2.Name = "vGridControl2";
            this.vGridControl2.RecordWidth = 176;
            this.vGridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueSpecialization,
            this.rilueHospital});
            this.vGridControl2.RowHeaderWidth = 24;
            this.vGridControl2.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rSpecializationId,
            this.rHospitalId});
            this.vGridControl2.Size = new System.Drawing.Size(901, 51);
            this.vGridControl2.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.vGridControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(905, 74);
            this.layoutControlItem2.Text = "Professional Info";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 16);
            // 
            // rAddress
            // 
            this.rAddress.Name = "rAddress";
            this.rAddress.Properties.Caption = "Address";
            this.rAddress.Properties.FieldName = "AddressId";
            this.rAddress.Properties.RowEdit = this.rilueAddress;
            // 
            // rilueAddress
            // 
            this.rilueAddress.AutoHeight = false;
            this.rilueAddress.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueAddress.DataSource = this.bsAddress;
            this.rilueAddress.DisplayMember = "Address";
            this.rilueAddress.KeyMember = "AddressId";
            this.rilueAddress.Name = "rilueAddress";
            this.rilueAddress.ValueMember = "AddressId";
            // 
            // bsDoctor
            // 
            this.bsDoctor.DataSource = typeof(Models.Classes.Doctor);
            // 
            // bsAddress
            // 
            this.bsAddress.DataSource = typeof(Models.Classes.AddressAsString);
            // 
            // rSpecializationId
            // 
            this.rSpecializationId.Name = "rSpecializationId";
            this.rSpecializationId.Properties.Caption = "Specialization";
            this.rSpecializationId.Properties.FieldName = "SpecializationId";
            this.rSpecializationId.Properties.RowEdit = this.rilueSpecialization;
            // 
            // rHospitalId
            // 
            this.rHospitalId.Name = "rHospitalId";
            this.rHospitalId.Properties.Caption = "Hospital";
            this.rHospitalId.Properties.FieldName = "HospitalId";
            this.rHospitalId.Properties.RowEdit = this.rilueHospital;
            // 
            // rilueSpecialization
            // 
            this.rilueSpecialization.AutoHeight = false;
            this.rilueSpecialization.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueSpecialization.DataSource = this.bsSpecialization;
            this.rilueSpecialization.DisplayMember = "Name";
            this.rilueSpecialization.KeyMember = "Id";
            this.rilueSpecialization.Name = "rilueSpecialization";
            this.rilueSpecialization.ValueMember = "Id";
            // 
            // rilueHospital
            // 
            this.rilueHospital.AutoHeight = false;
            this.rilueHospital.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueHospital.DataSource = this.bsHospital;
            this.rilueHospital.DisplayMember = "Name";
            this.rilueHospital.KeyMember = "Id";
            this.rilueHospital.Name = "rilueHospital";
            this.rilueHospital.ValueMember = "Id";
            // 
            // bsSpecialization
            // 
            this.bsSpecialization.DataSource = typeof(Models.Classes.DoctorSpecialization);
            // 
            // bsHospital
            // 
            this.bsHospital.DataSource = typeof(Models.Classes.Hospital);
            // 
            // sbSave
            // 
            this.sbSave.Location = new System.Drawing.Point(12, 205);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(901, 27);
            this.sbSave.StyleController = this.layoutControl1;
            this.sbSave.TabIndex = 6;
            this.sbSave.Text = "Save";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbSave;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 193);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(905, 31);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // DoctorPersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 244);
            this.Controls.Add(this.layoutControl1);
            this.Name = "DoctorPersonalInfo";
            this.Text = "DoctorPersonalInfo";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueSpecialization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpecialization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl2;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rFullName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rEmail;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rBirthDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource bsDoctor;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueSpecialization;
        private System.Windows.Forms.BindingSource bsSpecialization;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueHospital;
        private System.Windows.Forms.BindingSource bsHospital;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rSpecializationId;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rHospitalId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueAddress;
        private System.Windows.Forms.BindingSource bsAddress;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rAddress;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}