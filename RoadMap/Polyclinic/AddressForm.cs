using DevExpress.XtraEditors;
using Models.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Region = Models.Classes.Region;

namespace Polyclinic
{
    public partial class AddressForm : DevExpress.XtraEditors.XtraForm
    {
        public AddressForm(AddressType type)
        {
            InitializeComponent();
            ConfigureForm(type);
        }

        private void ConfigureForm(AddressType type)
        {
            switch (type)
            {
                case AddressType.CityType:
                    bsAddress.DataSource = CrudService.repository.ReadAll<CityTypes>().AllCityTypes;
                    gcAddress.MainView = gvCityType;
                    break;
                case AddressType.Region:
                    bsAddress.DataSource = CrudService.repository.ReadAll<Regions>().AllRegions;
                    gcAddress.MainView = gvRegion;
                    break;
                case AddressType.City:
                    bsAddress.DataSource = CrudService.repository.ReadAll<CityNames>().AllCityNames;
                    gcAddress.MainView = gvCity;
                    break;
                case AddressType.StreetName:
                    bsAddress.DataSource = CrudService.repository.ReadAll<StreetNames>().AllStreetNames;
                    gcAddress.MainView = gvStreet;
                    break;
                case AddressType.StreetType:
                    bsAddress.DataSource = CrudService.repository.ReadAll<StreetTypes>().AllStreetTypes;
                    gcAddress.MainView = gvStreetType;
                    break;
                case AddressType.BuildingNumber:
                    bsAddress.DataSource = CrudService.repository.ReadAll<BuildingNumbers>().AllBuildingNumbers;
                    gcAddress.MainView = gvBuildingNumber;
                    break;
                case AddressType.Address:
                    bsAddress.DataSource = CrudService.repository.ReadAll<Addresses>().AllAddresses;
                    lueRegions.DataSource = CrudService.repository.ReadAll<Regions>().AllRegions;
                    lueCityType.DataSource = CrudService.repository.ReadAll<CityTypes>().AllCityTypes;
                    lueCity.DataSource = CrudService.repository.ReadAll<CityNames>().AllCityNames;
                    lueStreet.DataSource = CrudService.repository.ReadAll<StreetNames>().AllStreetNames;
                    lueStreetType.DataSource = CrudService.repository.ReadAll<StreetTypes>().AllStreetTypes;
                    lueBuildingNumber.DataSource = CrudService.repository.ReadAll<BuildingNumbers>().AllBuildingNumbers;
                    break;
            }

            Text = type.ToString();

            gcAddress.RefreshDataSource();
        }

        public void CrudAction<T>(T model)
        {
            dynamic obj = model;
            if (obj.IsValid())
            {
                if (obj.Id == 0)
                {
                    obj.Id = CrudService.repository.Create<T>(model);
                }
                else
                {
                    CrudService.repository.Update<T>(model);
                }
            }
            else
            {
                XtraMessageBox.Show("Row is invalid, try again");
                obj = default;
            }
        }

        private void gvAddress_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            CrudAction<Address>(e.Row as Address);
        }

        private void gvRegion_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            CrudAction<Region>(e.Row as Region);
        }

        private void gvCityType_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            CrudAction<CityType>(e.Row as CityType);
        }

        private void gvCity_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            CrudAction<CityName>(e.Row as CityName);
        }

        private void gvStreetType_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            CrudAction<StreetType>(e.Row as StreetType);
        }

        private void gvStreet_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            CrudAction<StreetName>(e.Row as StreetName);
        }

        private void gvBuildingNumber_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            CrudAction<BuildingNumber>(e.Row as BuildingNumber);
        }
    }
}