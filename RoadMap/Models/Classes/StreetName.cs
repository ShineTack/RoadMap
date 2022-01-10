using System;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [CreateProc("proc_StreetName@Create")]
    [ReadProc("proc_StreetName@Read")]
    [UpdateProc("proc_StreetName@Update")]
    [DeleteProc("proc_StreetName@Delete")]
    [XmlRoot(ElementName = "StreetName")]
    public class StreetName
    {
        [XmlElement(ElementName = "Id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
    }
}