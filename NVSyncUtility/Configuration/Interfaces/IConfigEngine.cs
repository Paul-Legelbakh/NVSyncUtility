using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVSyncUtility.Configuration
{
    interface IConfigEngine<Entity> where Entity : class
    {
        List<Entity> LoadConfiguration(string configAddress);
    }
}
