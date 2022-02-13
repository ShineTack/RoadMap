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
    public partial class DoctorSpecialization : DevExpress.XtraEditors.XtraForm
    {
        public DoctorSpecialization()
        {
            InitializeComponent();
            bsDoctorSpecialization.DataSource = CrudService.repository.ReadAll<DoctorSpecializations>().AllDoctorSpecializations;
        }

        private void gvDoctorSpecialization_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var specialization = e.Row as Models.Classes.DoctorSpecialization;

            if(specialization.Id == 0)
            {
                specialization.Id = CrudService.repository.Create<Models.Classes.DoctorSpecialization>(specialization);
            }
            else
            {
                CrudService.repository.Update<Models.Classes.DoctorSpecialization>(specialization);
            }
        }
    }
}