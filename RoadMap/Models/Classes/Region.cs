using System;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [CreateProc("proc_Region@Create")]
    [ReadProc("proc_Region@Read")]
    [UpdateProc("proc_Region@Update")]
    [DeleteProc("proc_Region@Delete")]
    [XmlRoot(ElementName = "Region")]
    public class Region
    {
        [XmlElement(ElementName = "Id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        public bool IsValid()
        {
            return Name != string.Empty && Name != null;
        }
    }
}