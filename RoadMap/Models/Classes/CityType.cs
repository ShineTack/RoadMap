using System;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [CreateProc("proc_CityType@Create")]
    [ReadProc("proc_CityType@Read")]
    [UpdateProc("proc_CityType@Update")]
    [DeleteProc("proc_CityType@Delete")]
    [XmlRoot(ElementName = "CityType")]
    public class CityType
    {
        [XmlElement(ElementName = "Id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "Type")]
        public  string Type { get; set; }

        public bool IsValid()
        {
            return Type != string.Empty && Type != null;
        }
    }
}