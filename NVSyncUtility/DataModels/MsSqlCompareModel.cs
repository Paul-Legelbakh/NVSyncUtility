using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVSyncUtility.Models
{
    internal class MsSqlCompareModel : ICompareModel
    {
        internal Guid Id { get; set; }
        internal DateTime? CreatedOn { get; set; }
    }
}
