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
        Project,
        Research,
        SystemIssues,
        Training,
        BackOfficePrep,
        MicrophoneUnavailable,
        Meeting,
        Break,
        Coaching,
        CustomerFollowUp,
        ExternalEmailSupport,
        Lunch,
        ACWExtended,
        Offline,
        AgentAssist,
        MissedCallAgent,
        Callincoming,
        Oncall,
        Available
        
    }
}
