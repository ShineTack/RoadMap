using ProcedureInjectionFramework.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProcedureInjectionFramework.Core.Classes
{
    public class ProcedureInjectionInitializer
    {
        DataStorage dataStorage = null;

        public ProcedureInjectionInitializer(string connectionString)
        {  
            if(IsConfigurationFileExists())
            {

            }
            else
            {
                File.Create("ProcConfiguration.xml");
                Type[] types = Assembly.GetExecutingAssembly().GetTypes();
                List<Type> modelTypes = (from type in types
                                         where type.CustomAttributes.Any(attr => attr.AttributeType == typeof(ModelAttribute))
                                         select type).ToList();
                List<CRUDProc> procs = new List<CRUDProc>();
                foreach(Type modelType in modelTypes)
                {
                    CRUDProc proc = new CRUDProc();
                    proc.ModelName = modelType.Name;
                    if(modelType.GetCustomAttribute(typeof(CreateProcAttribute)) != null)
                    {
                        proc.CreateProc = modelType.GetCustomAttribute(typeof(CreateProcAttribute))
                            .GetType()
                            .GetProperty("ProcName")
                            .GetValue(modelType).ToString();
                    }
                    if (modelType.GetCustomAttribute(typeof(ReadProcAttribute)) != null)
                    {
                        proc.ReadProc = modelType.GetCustomAttribute(typeof(ReadProcAttribute))
                            .GetType()
                            .GetProperty("ProcName")
                            .GetValue(modelType).ToString();
                    }
                    if (modelType.GetCustomAttribute(typeof(UpdateProcAttribute)) != null)
                    {
                        proc.UpdateProc = modelType.GetCustomAttribute(typeof(UpdateProcAttribute))
                            .GetType()
                            .GetProperty("ProcName")
                            .GetValue(modelType).ToString();
                    }
                    if (modelType.GetCustomAttribute(typeof(DeleteProcAttribute)) != null)
                    {
                        proc.DeleteProc = modelType.GetCustomAttribute(typeof(DeleteProcAttribute))
                            .GetType()
                            .GetProperty("ProcName")
                            .GetValue(modelType).ToString();
                    }
                    procs.Add(proc);
                }
                dataStorage = new DataStorage(connectionString, procs);

                XmlSerializer writer = new XmlSerializer(typeof(DataStorage));

                var path = "ProcConfiguration.xml";
                FileStream file = File.Create(path);

                writer.Serialize(file, "Proc Configuration");
                file.Close();
            }
        }

        private bool IsConfigurationFileExists()
        {
            return File.Exists("ProcConfiguration.xml");
        }
    }
}
