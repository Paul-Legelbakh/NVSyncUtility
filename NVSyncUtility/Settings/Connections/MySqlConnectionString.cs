using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NVSyncUtility.Settings.Connections;
using NVSyncUtility.Settings.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVSyncUtility.Settings
{
    public class MySqlConnectionString
    {
        public MySqlConnectionString(string connectionFileAddress)
        {
            FileAddress = connectionFileAddress;
        }

        public string FileAddress { get; set; }
        public BaseJsonReader reader = new BaseJsonReader("mySql");

        public virtual string ConvertDictionaryToString()
        {
            SqlConnectionModel model = new SqlConnectionModel
            {
                Properties = reader.GetConnectionString(FileAddress)
            };
            string dbConnectionString = String.Format(@"Server={0}; Database={1}; Convert Zero Datetime=True; Uid={2}; Pwd={3}; charset=utf8",
                model.Properties["server"], model.Properties["db"], model.Properties["login"], model.Properties["password"]);

            return dbConnectionString;
        }
    }
}
