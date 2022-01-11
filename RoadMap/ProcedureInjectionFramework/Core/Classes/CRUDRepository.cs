using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProcedureInjectionFramework.Core.Classes
{
    public class CRUDRepository
    {
        private DataStorage _dataStorage;

        internal CRUDRepository (DataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }

        public void Create<T>(T model)
        {
            SqlConnection conn = new SqlConnection(_dataStorage.ConnectionString);
            string commandName = 
                _dataStorage
                    .procs
                    .Where(proc => proc.ModelName == model.GetType().Name)
                    .Select(proc => proc.CreateProc)
                    .ToArray()[0];
            SqlCommand cmd = new SqlCommand(commandName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@xmlData", ModelToXml<T>(model)));
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public T ReadById<T>(int id)
        {
                SqlConnection conn = new SqlConnection(_dataStorage.ConnectionString);
                string commandName = 
                    _dataStorage
                        .procs
                        .Where(proc => proc.ModelName == typeof(T).Name)
                        .Select(proc => proc.ReadProc)
                        .ToArray()[0];
                string xmlParameter = $"<Data><value>{id}</value></Data>";
                SqlCommand cmd = new SqlCommand(commandName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@xmlData", xmlParameter));
                cmd.Parameters.Add(new SqlParameter("@xmlResult", SqlDbType.NVarChar, 4000));
                cmd.Parameters["@xmlResult"].Direction = ParameterDirection.Output;
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return XmlToModel<T>(cmd.Parameters["@xmlResult"].Value.ToString());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                return default;
        }

        public T ReadAll<T>()
        {
            SqlConnection conn = new SqlConnection(_dataStorage.ConnectionString);
            string commandName = 
                _dataStorage
                    .procs
                    .Where(proc => proc.ModelName == typeof(T).Name)
                    .Select(proc => proc.ReadAllProc)
                    .ToArray()[0];
            SqlCommand cmd = new SqlCommand(commandName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@xmlResult", SqlDbType.NVarChar, 4000));
            cmd.Parameters["@xmlResult"].Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return XmlToModel<T>(cmd.Parameters["@xmlResult"].Value.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return default;
        }

        public void Update<T>(T model)
        {
            SqlConnection conn = new SqlConnection(_dataStorage.ConnectionString);
            string commandName = _dataStorage.procs.Where(proc => proc.ModelName == model.GetType().Name).Select(proc => proc.UpdateProc).ToArray()[0];
            SqlCommand cmd = new SqlCommand(commandName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@xmlData", ModelToXml<T>(model)));
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void Delete(dynamic model)
        {
            SqlConnection conn = new SqlConnection(_dataStorage.ConnectionString);
            string commandName = 
                _dataStorage
                    .procs
                    .Where(proc => proc.ModelName == model.GetType().Name)
                    .Select(proc => proc.DeleteProc)
                    .ToArray()[0];
            string xmlParameter = $"<Data><value>{(model.Id)}</value></Data>";
            SqlCommand cmd = new SqlCommand(commandName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@xmlData", xmlParameter));
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private string ModelToXml<T>(T model)
        {
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(model.GetType());
                serializer.Serialize(stringwriter, model);
               return stringwriter.ToString();
            }
        }

        private T XmlToModel<T>(string xml)
        {
            using (TextReader reader = new StringReader(xml))
            {
                return (T)new XmlSerializer(typeof(T)).Deserialize(reader);
            }
        }
    }
}
