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
    public partial class Disease : DevExpress.XtraEditors.XtraForm
    {
        public Disease(bool isDiseaseType)
        {
            InitializeComponent();
            bsDiseaseType.DataSource = CrudService.repository.ReadAll<DiseaseTypes>().AllDiseaseTypes;
            if (isDiseaseType)
            {
                gcDisease.MainView = gvDiseaseType;
                gcDisease.DataSource = bsDiseaseType;
            }
            else
            {
                bsDisease.DataSource = CrudService.repository.ReadAll<Diseases>().AllDiseases;
                gcDisease.DataSource = bsDisease;
            }
        }

        private void gvDisease_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var disease = e.Row as Models.Classes.Disease;
            if (disease.DiseaseTypeId <= 0) throw new Exception("DiseaseTypeId cannot be a 0!");

            if(disease.Id == 0)
            {
                disease.Id = CrudService.repository.Create(disease);
            }
            else
            {
                CrudService.repository.Update(disease);
            }
        }

        private void gvDiseaseType_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DiseaseType diseaseType = e.Row as DiseaseType;
            if(diseaseType.Id == 0)
            {
                diseaseType.Id = CrudService.repository.Create<DiseaseType>(diseaseType);
            }
            else
            {
                CrudService.repository.Update<DiseaseType>(diseaseType);
            }
        }
    }
}