using ProcedureInjectionFramework.Core.Classes;

namespace ProcedureInjectionFramework.Attributes
{
    public interface IDataAttribute
    {
        void SetProcValue(CRUDProc proc);
    }
}