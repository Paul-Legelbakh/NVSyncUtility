using NVSyncUtility.Settings.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NVSyncUtility.Settings.Connections;

namespace NVSyncUtility.Settings
{
    public class MsSqlConnectionString
    {
        public MsSqlConnectionString(string connectionFileAddress)
        {
            FileAddress = connectionFileAddress;
        }

        public string FileAddress { get; set; }
        public BaseJsonReader reader = new BaseJsonReader("msSql");
        
        public virtual string ConvertDictionaryToString()
        {
            SqlConnectionModel model = new SqlConnectionModel
            {
                Properties = reader.GetConnectionString(FileAddress)
            };
            string dbConnectionString = String.Format(@"Data Source={0}; Initial Catalog={1}; Persist Security Info=True; MultipleActiveResultSets=True; User ID={2}; Password={3}; Pooling = true; Max Pool Size = 200; ConnectRetryCount=2; Asynchronous Processing=true; Async = true",
                model.Properties["server"], model.Properties["db"], model.Properties["login"], model.Properties["password"]);

            return dbConnectionString;
        }
    }
}
