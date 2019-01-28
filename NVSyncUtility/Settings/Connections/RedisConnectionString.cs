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
    public class RedisConnectionString
    {
        public RedisConnectionString(string connectionFileAddress)
        {
            FileAddress = connectionFileAddress;
        }

        public string FileAddress { get; set; }
        public BaseJsonReader reader = new BaseJsonReader("redis");

        public virtual string ConvertDictionaryToString()
        {
            RedisConnectionModel model = new RedisConnectionModel
            {
                Properties = reader.GetConnectionString(FileAddress)
            };
            string dbConnectionString = String.Format(@"host = {0}; db = {1}; port = {2}; maxReadPoolSize = 250; maxWritePoolSize = 250",
                model.Properties["host"], model.Properties["db"], model.Properties["port"]);

            return dbConnectionString;
        }
    }
}
