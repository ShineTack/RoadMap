using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcedureInjectionFramework.Core.Classes;

namespace ProcedureInjectionFramework.Attributes
{
    public class DeleteProcAttribute : Attribute, IDataAttribute
    {
        public string ProcName { get; private set; }

        public DeleteProcAttribute(string procName)
        {
            ProcName = procName;
        }

        public void SetProcValue(CRUDProc proc)
        {
            proc.DeleteProc = ProcName;
        }
    }
}
