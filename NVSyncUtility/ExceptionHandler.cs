using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVSyncUtility
{
    public static class ExceptionHandler
    {
        public static string GetErrorInfo(Exception exc)
        {
            var report = String.Format(@"Message:: {0},\nSource:: {1},\nData:: {2},\nInnerException:: {3};\n",
                exc.Message, exc.Source, exc.Data, exc.InnerException);
            return report;
        }
    }
}
