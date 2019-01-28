using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVSyncUtility.Settings.Models
{
    public class RedisConnectionModel : BaseConnectionModel
    {
        public RedisConnectionModel()
        {
            Properties = new Dictionary<string, string>
            {
                { "host", "" },
                { "port", "" },
                { "db", "" }
            };
        }
    }
}
