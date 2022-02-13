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
    public partial class NoteIllnessCertificate : DevExpress.XtraEditors.XtraForm
    {
        private IllnessCertificate Certificate { get; set; }
        public NoteIllnessCertificate(IllnessCertificate certificate)
        {
            InitializeComponent();
            Certificate = certificate;
            List<Models.Classes.NoteIllnessCertificate> notes = CrudService.repository.ReadAll<NotesIllnessCertificate>().AllNotesIllnessCertificate;
            bsNotes.DataSource = (from n in notes
                                  where n.IllnessCertificateId == certificate.Id
                                  select n).ToList();
        }

        private void gvNotes_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var note = e.Row as Models.Classes.NoteIllnessCertificate;
            note.IllnessCertificateId = Certificate.Id;
            if (note.Id == 0) CrudService.repository.Create<Models.Classes.NoteIllnessCertificate>(note);
        }
    }
}