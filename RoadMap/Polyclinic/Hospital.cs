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

namespace Polyclinic
{
    public partial class Hospital : DevExpress.XtraEditors.XtraForm
    {
        public Hospital()
        {
            InitializeComponent();
            bsAddresses.DataSource = CrudService.repository.ReadAll<AddressesAsString>().AllAddresses;
            bsHospital.DataSource = CrudService.repository.ReadAll<Models.Classes.Hospitals>().AllHospitals;
        }

        private void gvHospital_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var hospital = e.Row as Models.Classes.Hospital;
            if (hospital.AddressId <= 0) throw new Exception("AddressId cannot be a 0!");

            if (hospital.Id == 0) 
            {
                hospital.Id = CrudService.repository.Create<Models.Classes.Hospital>(hospital);
            }
            else
            {
                CrudService.repository.Update<Models.Classes.Hospital>(hospital);
            }
        }
    }
}