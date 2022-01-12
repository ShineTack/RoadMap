using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [ReadAll("proc_Address@ReadAll")]
    [XmlRoot(ElementName = "Data")]
    public class Addresses
    {
        [XmlElement(ElementName = "Addresses", Type = typeof(List<Address>))]
        public List<Address> AllAddresses { get; set; }
    }
}