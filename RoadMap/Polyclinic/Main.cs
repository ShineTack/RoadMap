using DevExpress.XtraEditors;
using Models.Classes;

namespace Polyclinic
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            CrudService.CrudServiceInitialize();
            Infoses infoses = CrudService.repository.ReadAll<Infoses>();
            bsInfoses.DataSource = infoses.AllInfo;
            pgcInfoses.RefreshData();
        }



        private void ShowAddress(AddressType type)
        {
            AddressForm address = new AddressForm(type);
            address.Show();
        }

        private void bbiCityType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowAddress(AddressType.CityType);
        }

        private void bbiRegion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowAddress(AddressType.Region);
        }

        private void bbiCity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowAddress(AddressType.City);
        }

        private void bbiStreetName_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowAddress(AddressType.StreetName);
        }

        private void bbiStreetType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowAddress(AddressType.StreetType);
        }

        private void bbiBuildingNumbers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowAddress(AddressType.BuildingNumber);
        }

        private void bbiAddress_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowAddress(AddressType.Address);
        }

        private void bbiAddHospital_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Hospital().Show();
        }

        private void bbiDiseaseList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Disease(false).Show();
        }

        private void bbiDiseaseTypeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Disease(true).Show();
        }

        private void bbiPatients_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Persons(false).Show();
        }

        private void bbiDoctor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Persons(true).Show();
        }

        private void bbiDoctorSpecializationList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new DoctorSpecialization().Show();
        }

        private void tsmiUpdate_Click(object sender, System.EventArgs e)
        {
            bsInfoses.DataSource = CrudService.repository.ReadAll<Infoses>().AllInfo;
        }
    }
}
