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
    public partial class DoctorPersonalInfo : DevExpress.XtraEditors.XtraForm
    {
        private Doctor _doctor;
        private BindingSource _source;
        public DoctorPersonalInfo(Doctor doctor, BindingSource source)
        {
            InitializeComponent();
            _source = source;
            _doctor = doctor;
            bsDoctor.DataSource = doctor;
            bsAddress.DataSource = CrudService.repository.ReadAll<AddressesAsString>().AllAddresses;
            bsHospital.DataSource = CrudService.repository.ReadAll<Hospitals>().AllHospitals;
            bsSpecialization.DataSource = CrudService.repository.ReadAll<DoctorSpecializations>().AllDoctorSpecializations;
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            if(_doctor.Id == 0)
            {
                _doctor.Id = CrudService.repository.Create<Doctor>(_doctor);
                _source.DataSource = CrudService.repository.ReadAll<Doctors>().AllDoctors;
            }
            else
            {
                CrudService.repository.Update<Doctor>(_doctor);
                _source.DataSource = CrudService.repository.ReadAll<Doctors>().AllDoctors;
            }
        }
    }
}