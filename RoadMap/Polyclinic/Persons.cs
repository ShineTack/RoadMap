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
    public partial class Persons : DevExpress.XtraEditors.XtraForm
    {
        private bool IsDoctor { get; set; }
        public Persons(bool isDoctor)
        {
            InitializeComponent();

            IsDoctor = isDoctor;

            if (isDoctor)
            {
                Text = "Doctors";
                bsPersons.DataSource = CrudService.repository.ReadAll<Doctors>().AllDoctors;
            }
            else
            {
                Text = "Patients";
                bsPersons.DataSource = CrudService.repository.ReadAll<Patients>().AllPatients;
            }

            gcPersons.DataSource = bsPersons;
        }

        private void tsmiAddNew_Click(object sender, EventArgs e)
        {
            if (IsDoctor)
            {
                new DoctorPersonalInfo(new Doctor(), bsPersons).Show();
            }
            else
            {
                new PatientPersonalInfo(new Patient(), bsPersons).Show();
            }
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            if (IsDoctor)
            {
                var doctor = (Doctor)gvDoctors.GetRow(gvDoctors.GetSelectedRows()[0]);
                new DoctorPersonalInfo(doctor, bsPersons).Show();
            }
            else
            {
                var patient = (Patient)gvDoctors.GetRow(gvDoctors.GetSelectedRows()[0]);
                new PatientPersonalInfo(patient, bsPersons).Show();
            }
        }
    }
}