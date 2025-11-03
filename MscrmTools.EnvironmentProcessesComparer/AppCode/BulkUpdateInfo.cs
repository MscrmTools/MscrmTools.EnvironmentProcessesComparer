using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MscrmTools.EnvironmentProcessesComparer.AppCode
{
    internal class BulkUpdateInfo
    {
        public string Message { get; set; }
        public string ProcessName { get; set; }
        public bool Success { get; set; }
        public string TargetEnvironment { get; set; }
    }
}