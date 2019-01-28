using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVSyncUtility.Settings
{
    public class ConnectionProperties
    {
        public ConnectionProperties(string connectionFileAddress)
        {
            ms = new MsSqlConnectionString(connectionFileAddress);
            my = new MySqlConnectionString(connectionFileAddress);
            rs = new RedisConnectionString(connectionFileAddress);

            msSqlConnectionString = ms.ConvertDictionaryToString();
            mySqlConnectionString = my.ConvertDictionaryToString();
            redisConnectionString = rs.ConvertDictionaryToString();
        }

        private MsSqlConnectionString ms;
        private MySqlConnectionString my;
        private RedisConnectionString rs;

        public readonly string msSqlConnectionString = "";
        public readonly string mySqlConnectionString = "";
        public readonly string redisConnectionString = "";
    }
}
