
namespace Polyclinic
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPivotGrid.PivotGridCustomTotal pivotGridCustomTotal1 = new DevExpress.XtraPivotGrid.PivotGridCustomTotal();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pgcInfoses = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.cmsInfoses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.bsInfoses = new System.Windows.Forms.BindingSource(this.components);
            this.fieldCertificateId1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFirstVisit1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLastVisit1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiseaseName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiseaseType1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPatientName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPatientEmail1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDoctorName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDoctorSpecialization1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHospitalName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bmModels = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bsiAdress = new DevExpress.XtraBars.BarSubItem();
            this.bbiCity = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCityType = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRegion = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStreetName = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStreetType = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBuildingNumbers = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAddress = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAddHospital = new DevExpress.XtraBars.BarButtonItem();
            this.bsiDisease = new DevExpress.XtraBars.BarSubItem();
            this.bbiDiseaseList = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDiseaseTypeList = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDoctorSpecializationList = new DevExpress.XtraBars.BarButtonItem();
            this.bsiPersons = new DevExpress.XtraBars.BarSubItem();
            this.bbiDoctor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPatients = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgcInfoses)).BeginInit();
            this.cmsInfoses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsInfoses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmModels)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.pgcInfoses);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 56);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1128, 464);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pgcInfoses
            // 
            this.pgcInfoses.ContextMenuStrip = this.cmsInfoses;
            this.pgcInfoses.DataSource = this.bsInfoses;
            this.pgcInfoses.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCertificateId1,
            this.fieldFirstVisit1,
            this.fieldLastVisit1,
            this.fieldDiseaseName1,
            this.fieldDiseaseType1,
            this.fieldPatientName1,
            this.fieldPatientEmail1,
            this.fieldDoctorName1,
            this.fieldDoctorSpecialization1,
            this.fieldHospitalName1});
            this.pgcInfoses.Location = new System.Drawing.Point(12, 12);
            this.pgcInfoses.Name = "pgcInfoses";
            this.pgcInfoses.Size = new System.Drawing.Size(1104, 440);
            this.pgcInfoses.TabIndex = 4;
            // 
            // cmsInfoses
            // 
            this.cmsInfoses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsInfoses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdate});
            this.cmsInfoses.Name = "cmsInfoses";
            this.cmsInfoses.Size = new System.Drawing.Size(128, 28);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(127, 24);
            this.tsmiUpdate.Text = "Update";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // bsInfoses
            // 
            this.bsInfoses.DataSource = typeof(Models.Classes.Info);
            // 
            // fieldCertificateId1
            // 
            this.fieldCertificateId1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCertificateId1.AreaIndex = 0;
            this.fieldCertificateId1.Caption = "Certificate";
            this.fieldCertificateId1.CustomTotals.AddRange(new DevExpress.XtraPivotGrid.PivotGridCustomTotal[] {
            pivotGridCustomTotal1});
            this.fieldCertificateId1.FieldName = "CertificateId";
            this.fieldCertificateId1.Name = "fieldCertificateId1";
            this.fieldCertificateId1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // fieldFirstVisit1
            // 
            this.fieldFirstVisit1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldFirstVisit1.AreaIndex = 0;
            this.fieldFirstVisit1.Caption = "FirstVisit";
            this.fieldFirstVisit1.FieldName = "FirstVisit";
            this.fieldFirstVisit1.Name = "fieldFirstVisit1";
            // 
            // fieldLastVisit1
            // 
            this.fieldLastVisit1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldLastVisit1.AreaIndex = 1;
            this.fieldLastVisit1.Caption = "LastVisit";
            this.fieldLastVisit1.FieldName = "LastVisit";
            this.fieldLastVisit1.Name = "fieldLastVisit1";
            // 
            // fieldDiseaseName1
            // 
            this.fieldDiseaseName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDiseaseName1.AreaIndex = 6;
            this.fieldDiseaseName1.Caption = "Disease Name";
            this.fieldDiseaseName1.FieldName = "DiseaseName";
            this.fieldDiseaseName1.Name = "fieldDiseaseName1";
            // 
            // fieldDiseaseType1
            // 
            this.fieldDiseaseType1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDiseaseType1.AreaIndex = 5;
            this.fieldDiseaseType1.Caption = "Disease Type";
            this.fieldDiseaseType1.FieldName = "DiseaseType";
            this.fieldDiseaseType1.Name = "fieldDiseaseType1";
            // 
            // fieldPatientName1
            // 
            this.fieldPatientName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPatientName1.AreaIndex = 0;
            this.fieldPatientName1.Caption = "Patient Name";
            this.fieldPatientName1.FieldName = "PatientName";
            this.fieldPatientName1.Name = "fieldPatientName1";
            // 
            // fieldPatientEmail1
            // 
            this.fieldPatientEmail1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPatientEmail1.AreaIndex = 1;
            this.fieldPatientEmail1.Caption = "Patient Email";
            this.fieldPatientEmail1.FieldName = "PatientEmail";
            this.fieldPatientEmail1.Name = "fieldPatientEmail1";
            // 
            // fieldDoctorName1
            // 
            this.fieldDoctorName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDoctorName1.AreaIndex = 2;
            this.fieldDoctorName1.Caption = "Doctor Name";
            this.fieldDoctorName1.FieldName = "DoctorName";
            this.fieldDoctorName1.Name = "fieldDoctorName1";
            // 
            // fieldDoctorSpecialization1
            // 
            this.fieldDoctorSpecialization1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDoctorSpecialization1.AreaIndex = 3;
            this.fieldDoctorSpecialization1.Caption = "Doctor Specialization";
            this.fieldDoctorSpecialization1.FieldName = "DoctorSpecialization";
            this.fieldDoctorSpecialization1.Name = "fieldDoctorSpecialization1";
            // 
            // fieldHospitalName1
            // 
            this.fieldHospitalName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldHospitalName1.AreaIndex = 4;
            this.fieldHospitalName1.Caption = "Hospital Name";
            this.fieldHospitalName1.FieldName = "HospitalName";
            this.fieldHospitalName1.Name = "fieldHospitalName1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1128, 464);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pgcInfoses;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1108, 444);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // bmModels
            // 
            this.bmModels.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.bmModels.DockControls.Add(this.barDockControlTop);
            this.bmModels.DockControls.Add(this.barDockControlBottom);
            this.bmModels.DockControls.Add(this.barDockControlLeft);
            this.bmModels.DockControls.Add(this.barDockControlRight);
            this.bmModels.Form = this;
            this.bmModels.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bsiAdress,
            this.bbiCity,
            this.bbiCityType,
            this.bbiRegion,
            this.bbiStreetName,
            this.bbiStreetType,
            this.bbiBuildingNumbers,
            this.bbiAddress,
            this.bbiAddHospital,
            this.bsiDisease,
            this.bbiDiseaseList,
            this.bbiDiseaseTypeList,
            this.bsiPersons,
            this.bbiDoctor,
            this.bbiPatients,
            this.bbiDoctorSpecializationList});
            this.bmModels.MainMenu = this.bar2;
            this.bmModels.MaxItemId = 16;
            this.bmModels.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Сервис";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiAdress),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddHospital),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiDisease),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiPersons)});
            this.bar1.Text = "Сервис";
            // 
            // bsiAdress
            // 
            this.bsiAdress.Caption = "Adress";
            this.bsiAdress.Id = 0;
            this.bsiAdress.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCity),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCityType),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRegion),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStreetName),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStreetType),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiBuildingNumbers),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddress)});
            this.bsiAdress.Name = "bsiAdress";
            // 
            // bbiCity
            // 
            this.bbiCity.Caption = "City";
            this.bbiCity.Id = 1;
            this.bbiCity.Name = "bbiCity";
            this.bbiCity.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCity_ItemClick);
            // 
            // bbiCityType
            // 
            this.bbiCityType.Caption = "CityType";
            this.bbiCityType.Id = 2;
            this.bbiCityType.Name = "bbiCityType";
            this.bbiCityType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCityType_ItemClick);
            // 
            // bbiRegion
            // 
            this.bbiRegion.Caption = "Region";
            this.bbiRegion.Id = 3;
            this.bbiRegion.Name = "bbiRegion";
            this.bbiRegion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRegion_ItemClick);
            // 
            // bbiStreetName
            // 
            this.bbiStreetName.Caption = "StreetName";
            this.bbiStreetName.Id = 4;
            this.bbiStreetName.Name = "bbiStreetName";
            this.bbiStreetName.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiStreetName_ItemClick);
            // 
            // bbiStreetType
            // 
            this.bbiStreetType.Caption = "StreetType";
            this.bbiStreetType.Id = 5;
            this.bbiStreetType.Name = "bbiStreetType";
            this.bbiStreetType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiStreetType_ItemClick);
            // 
            // bbiBuildingNumbers
            // 
            this.bbiBuildingNumbers.Caption = "BuildingNumber";
            this.bbiBuildingNumbers.Id = 6;
            this.bbiBuildingNumbers.Name = "bbiBuildingNumbers";
            this.bbiBuildingNumbers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiBuildingNumbers_ItemClick);
            // 
            // bbiAddress
            // 
            this.bbiAddress.Caption = "Address";
            this.bbiAddress.Id = 7;
            this.bbiAddress.Name = "bbiAddress";
            this.bbiAddress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddress_ItemClick);
            // 
            // bbiAddHospital
            // 
            this.bbiAddHospital.Caption = "Hospitals";
            this.bbiAddHospital.Id = 8;
            this.bbiAddHospital.Name = "bbiAddHospital";
            this.bbiAddHospital.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddHospital_ItemClick);
            // 
            // bsiDisease
            // 
            this.bsiDisease.Caption = "Disease";
            this.bsiDisease.Id = 9;
            this.bsiDisease.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDiseaseList),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDiseaseTypeList),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDoctorSpecializationList)});
            this.bsiDisease.Name = "bsiDisease";
            // 
            // bbiDiseaseList
            // 
            this.bbiDiseaseList.Caption = "Disease List";
            this.bbiDiseaseList.Id = 10;
            this.bbiDiseaseList.Name = "bbiDiseaseList";
            this.bbiDiseaseList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDiseaseList_ItemClick);
            // 
            // bbiDiseaseTypeList
            // 
            this.bbiDiseaseTypeList.Caption = "Disease Type List";
            this.bbiDiseaseTypeList.Id = 11;
            this.bbiDiseaseTypeList.Name = "bbiDiseaseTypeList";
            this.bbiDiseaseTypeList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDiseaseTypeList_ItemClick);
            // 
            // bbiDoctorSpecializationList
            // 
            this.bbiDoctorSpecializationList.Caption = "Doctor Specialization List";
            this.bbiDoctorSpecializationList.Id = 15;
            this.bbiDoctorSpecializationList.Name = "bbiDoctorSpecializationList";
            this.bbiDoctorSpecializationList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDoctorSpecializationList_ItemClick);
            // 
            // bsiPersons
            // 
            this.bsiPersons.Caption = "Persons";
            this.bsiPersons.Id = 12;
            this.bsiPersons.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDoctor),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPatients)});
            this.bsiPersons.Name = "bsiPersons";
            // 
            // bbiDoctor
            // 
            this.bbiDoctor.Caption = "Doctors";
            this.bbiDoctor.Id = 13;
            this.bbiDoctor.Name = "bbiDoctor";
            this.bbiDoctor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDoctor_ItemClick);
            // 
            // bbiPatients
            // 
            this.bbiPatients.Caption = "Patients";
            this.bbiPatients.Id = 14;
            this.bbiPatients.Name = "bbiPatients";
            this.bbiPatients.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPatients_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Главное меню";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Главное меню";
            // 
            // bar3
            // 
            this.bar3.BarName = "Строка состояния";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Строка состояния";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bmModels;
            this.barDockControlTop.Size = new System.Drawing.Size(1128, 56);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 520);
            this.barDockControlBottom.Manager = this.bmModels;
            this.barDockControlBottom.Size = new System.Drawing.Size(1128, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 56);
            this.barDockControlLeft.Manager = this.bmModels;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 464);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1128, 56);
            this.barDockControlRight.Manager = this.bmModels;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 464);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 544);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MainForm";
            this.Text = "Polyclinic";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgcInfoses)).EndInit();
            this.cmsInfoses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsInfoses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmModels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraPivotGrid.PivotGridControl pgcInfoses;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager bmModels;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem bsiAdress;
        private DevExpress.XtraBars.BarButtonItem bbiCity;
        private DevExpress.XtraBars.BarButtonItem bbiCityType;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiRegion;
        private DevExpress.XtraBars.BarButtonItem bbiStreetName;
        private DevExpress.XtraBars.BarButtonItem bbiStreetType;
        private DevExpress.XtraBars.BarButtonItem bbiBuildingNumbers;
        private DevExpress.XtraBars.BarButtonItem bbiAddress;
        private System.Windows.Forms.BindingSource bsInfoses;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCertificateId1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFirstVisit1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLastVisit1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDiseaseName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDiseaseType1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPatientName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPatientEmail1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDoctorName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDoctorSpecialization1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHospitalName1;
        private DevExpress.XtraBars.BarButtonItem bbiAddHospital;
        private DevExpress.XtraBars.BarSubItem bsiDisease;
        private DevExpress.XtraBars.BarButtonItem bbiDiseaseList;
        private DevExpress.XtraBars.BarButtonItem bbiDiseaseTypeList;
        private DevExpress.XtraBars.BarSubItem bsiPersons;
        private DevExpress.XtraBars.BarButtonItem bbiDoctor;
        private DevExpress.XtraBars.BarButtonItem bbiPatients;
        private DevExpress.XtraBars.BarButtonItem bbiDoctorSpecializationList;
        private System.Windows.Forms.ContextMenuStrip cmsInfoses;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
    }
}

