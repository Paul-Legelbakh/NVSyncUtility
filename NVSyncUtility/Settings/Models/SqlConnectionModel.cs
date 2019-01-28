using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVSyncUtility.Settings.Models
{
    public class SqlConnectionModel : BaseConnectionModel
    {
        public SqlConnectionModel()
        {
            Properties = new Dictionary<string, string>
            {
                { "login", "" },
                { "password", "" },
                { "server", "" },
                { "db", "" }
            };
        }
    }
}
