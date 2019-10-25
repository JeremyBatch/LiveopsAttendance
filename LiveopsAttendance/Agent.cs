using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveopsAttendance
{
    class Agent
    {
        public string Name { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        Unknown,
        OnCall,
        Available,
        Hold
    }
}
