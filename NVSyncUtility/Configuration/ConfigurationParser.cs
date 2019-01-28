using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NVSyncUtility.Configuration.ConfigurationModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NVSyncUtility.Configuration
{
    public class ConfigurationParser : IConfigEngine<JsonConfigEntity>
    {
        public virtual List<JsonConfigEntity> LoadConfiguration(string configAddress)
        {
            List<JsonConfigEntity> jsonEntities = new List<JsonConfigEntity>();
            using (StreamReader r = new StreamReader(configAddress))
            {
                try
                {
                    string json = r.ReadToEnd();
                    var convertedJson = JArray.Parse(json);
                    foreach (JObject token in convertedJson)
                    {
                        JsonConfigEntity obj = new JsonConfigEntity()
                        {
                            msSql = token["mssql"].ToString(),
                            mySql = token["mysql"].ToString(),
                            entityFields = JsonConvert.DeserializeObject<Dictionary<string, string>>(token["fields"].ToString()),
                            entityTypes = JsonConvert.DeserializeObject<Dictionary<string, string>>(token["types"].ToString()),
                            entityAttributes = JsonConvert.DeserializeObject<Dictionary<string, string>>(token["attributes"].ToString())
                        };
                        jsonEntities.Add(obj);
                    }
                }
                catch (Exception ex)
                {

                }
            }
            return jsonEntities;
        }
    }
}
