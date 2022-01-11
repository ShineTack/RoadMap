using System;

namespace ProcedureInjectionFramework.Core.Classes
{
    [Serializable]
    public class CRUDProc
    {
        public string ModelName { get; set; }
        public string CreateProc { get; set; }
        public string ReadProc { get; set; }
        
        public string ReadAllProc { get; set; }
        public string UpdateProc { get; set; }
        public string DeleteProc { get; set; }
    }
}