using ProcedureInjectionFramework.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models.Classes
{
    [Model]
    [ReadAll("proc_NoteIllnessCertificate@ReadAll")]
    [Serializable]
    [XmlRoot(ElementName = "Data")]
    public class NotesIllnessCertificate
    {
        [XmlElement(ElementName = "NotesIllnessCertificate", Type = typeof(List<NoteIllnessCertificate>))]
        public List<NoteIllnessCertificate> AllNotesIllnessCertificate { get; set; }
    }
}
