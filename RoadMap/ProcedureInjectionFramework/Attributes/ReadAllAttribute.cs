using System;
using ProcedureInjectionFramework.Core.Classes;

namespace ProcedureInjectionFramework.Attributes
{
    public class ReadAllAttribute : Attribute, IDataAttribute
    {
        public string ProcName { get; set; }

        public ReadAllAttribute(string procName)
        {
            ProcName = procName;
        }
        public void SetProcValue(CRUDProc proc)
        {
            proc.ReadAllProc = ProcName;
        }
    }
}