using System;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [CreateProc("proc_StreetType@Create")]
    [ReadProc("proc_StreetType@Read")]
    [UpdateProc("proc_StreetType@Update")]
    [DeleteProc("proc_StreetType@Delete")]
    [XmlRoot(ElementName = "StreetType")]
    public class StreetType
    {
        [XmlElement(ElementName = "Id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }

        public bool IsValid()
        {
            return Type != string.Empty && Type != null;
        }
    }
}