using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVSyncUtility.Settings.Connections
{
    public class BaseJsonReader : IConnectionHandler
    {
        public BaseJsonReader(string dbType)
        {
            DbType = dbType;
        }
        public string DbType { get; set; }

        public virtual Dictionary<string, string> GetConnectionString(string connectionFileAddress)
        {
            Dictionary<string, string> jsonEntities = new Dictionary<string, string>();
            try
            {
                using (StreamReader r = new StreamReader(connectionFileAddress))
                {
                    string json = r.ReadToEnd();
                    var convertedJson = JArray.Parse(json);
                    jsonEntities = JsonConvert.DeserializeObject<Dictionary<string, string>>(DbType);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return jsonEntities;
        }
    }
}
