using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVSyncUtility.Settings
{
    public interface IConnectionHandler
    {
        Dictionary<string,string> GetConnectionString(string connectionFileAddress = "");
    }
}
