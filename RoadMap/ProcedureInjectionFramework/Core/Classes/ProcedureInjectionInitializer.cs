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

        public ProcedureInjectionInitializer(string connectionString, Type[] types)
        {  
            if(IsConfigurationFileExists())
            {
                FileStream fileStream = File.OpenRead("ProcConfiguration.xml");
                XmlSerializer reader = new XmlSerializer(typeof(DataStorage));
                dataStorage = (DataStorage)reader.Deserialize(fileStream);
                fileStream.Close();
            }
            else
            {
                List<Type> modelTypes = (from type in types
                                         where type.CustomAttributes.Any(attr => attr.AttributeType == typeof(ModelAttribute))
                                         select type).ToList();
                List<CRUDProc> procs = new List<CRUDProc>();
                foreach(Type modelType in modelTypes)
                {
                    CRUDProc proc = new CRUDProc();
                    proc.ModelName = modelType.Name;
                    foreach(Attribute attribute in modelType.GetCustomAttributes(true))
                    {
                        if (attribute is CreateProcAttribute create)
                        {
                            proc.CreateProc = create.ProcName;
                        }
                        else if (attribute is ReadProcAttribute read)
                        {
                            proc.ReadProc = read.ProcName;
                        }
                        else if (attribute is UpdateProcAttribute update)
                        {
                            proc.UpdateProc = update.ProcName;
                        }
                        else if (attribute is DeleteProcAttribute delete)
                        {
                            proc.DeleteProc = delete.ProcName;
                        }
                    }
                    procs.Add(proc);
                }
                dataStorage = new DataStorage(connectionString, procs);

                try
                {
                    XmlSerializer writer = new XmlSerializer(typeof(DataStorage));

                    var path = "ProcConfiguration.xml";
                    FileStream file = File.Create(path);

                    writer.Serialize(file, dataStorage);
                    file.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private bool IsConfigurationFileExists()
        {
            return File.Exists("ProcConfiguration.xml");
        }

        public CRUDRepository GetCRUDRepository()
        {
            return new CRUDRepository(dataStorage);
        }
    }
}
