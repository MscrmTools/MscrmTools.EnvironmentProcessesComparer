using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;

namespace MscrmTools.EnvironmentProcessesComparer.AppCode
{
    public class StateChangeEventArgs
    {
        public ConnectionDetail ConnectionDetail { get; set; }
        public Entity record { get; set; }
        public int State { get; set; }
        public int SubItemIndex { get; internal set; }
    }
}