using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVSyncUtility.Configuration.ConfigurationModels
{
    public class JsonConfigEntity
    {
        public string msSql { get; set; }

        public string mySql { get; set; }

        public Dictionary<string, string> entityFields { get; set; }

        public Dictionary<string, string> entityTypes { get; set; }

        public Dictionary<string, string> entityAttributes { get; set; }
    }
}
