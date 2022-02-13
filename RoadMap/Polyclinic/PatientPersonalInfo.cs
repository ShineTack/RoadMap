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
    public partial class PatientPersonalInfo : DevExpress.XtraEditors.XtraForm
    {

        private Patient Patient { get; set; }
        private BindingSource Binding { get; set; }
        public PatientPersonalInfo(Patient patient, BindingSource binding)
        {
            InitializeComponent();
            Patient = patient;
            Binding = binding;
            bsPatient.DataSource = patient;
            bsAddresses.DataSource = CrudService.repository.ReadAll<AddressesAsString>().AllAddresses;
            List<IllnessCertificate> certificates = CrudService.repository.ReadAll<IllnessCertificates>().AllIllnessCertificates;
            bsIllnessCertificates.DataSource = (from ic in certificates
                                                where ic.PatientId == patient.Id
                                                select ic).ToList();
            bsDiseases.DataSource = CrudService.repository.ReadAll<Diseases>().AllDiseases;
            bsDoctors.DataSource = CrudService.repository.ReadAll<Doctors>().AllDoctors;
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            if (Patient.Id == 0) Patient.Id = CrudService.repository.Create<Patient>(Patient);
            else CrudService.repository.Update<Patient>(Patient);
            Binding.DataSource = CrudService.repository.ReadAll<Patients>().AllPatients;
        }

        private void gvIllnessCertificate_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            IllnessCertificate certificate = e.Row as IllnessCertificate;
            certificate.PatientId = Patient.Id;
            if (certificate.Id == 0) certificate.Id = CrudService.repository.Create(certificate);
        }

        private void gvIllnessCertificate_DoubleClick(object sender, EventArgs e)
        {
            if(gvIllnessCertificate.SelectedRowsCount == 1)
            {
                IllnessCertificate certificate = (IllnessCertificate)gvIllnessCertificate.GetRow(gvIllnessCertificate.GetSelectedRows()[0]);
                new NoteIllnessCertificate(certificate).Show();
            }
        }
    }
}