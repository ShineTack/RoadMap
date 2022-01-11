using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcedureInjectionFramework.Core.Classes;

namespace ProcedureInjectionFramework.Attributes
{
    public class ReadProcAttribute : Attribute, IDataAttribute
    {
        public string ProcName { get; private set; }

        public ReadProcAttribute(string procName)
        {
            ProcName = procName;
        }

        public void SetProcValue(CRUDProc proc)
        {
            proc.ReadProc = ProcName;
        }
    }
}
