using System;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [CreateProc("proc_CityName@Create")]
    [ReadProc("proc_CityName@Read")]
    [UpdateProc("proc_CityName@Update")]
    [DeleteProc("proc_CityName@Delete")]
    [XmlRoot(ElementName = "CityName")]
    public class CityName
    {
        [XmlElement(ElementName = "Id")]
        public  int Id { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        public bool IsValid()
        {
            return Name != string.Empty && Name != null;
        }
    }
}