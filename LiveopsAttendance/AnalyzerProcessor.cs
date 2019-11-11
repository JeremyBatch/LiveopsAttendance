using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveopsAttendance
{
    class AnalyzerProcessor
    {
        public List<Agent> GetAgents(string text, bool scheduledAgents = true)
        {
            var agentStrings = text.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            if (!scheduledAgents)
            {
                agentStrings = CreateAgentLines(agentStrings.ToArray());
            }
            //This currently will return an agent name (line 1) then agent status (line 2) and repeat
            //var textToArray = CreateAgentLines(text.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries));
            var results = new List<Agent>();

            //create a method that makes this next line usable - convert the array of strings into a concantinated array of strings


            foreach (var line in agentStrings)
            {
                results.Add(ParseLine(line));
            }
            
            return results;
        }
        //line = "Appolonia\tBarnett\t On call"
        private Agent ParseLine(string line)
        {
            line = line.Replace('\t', ' ');
            var parts = line.Split(' ');
            var status = string.Join("", parts.Where((s, i) => i > 1).Select(s => s).ToArray());
            return new Agent
            {
                Name = $"{parts[0]} {parts[1]}",
                Status = status.Length > 0 ? (Status)Enum.Parse(typeof(Status), status, true) : Status.Unknown
            };
        }
        private List<string> CreateAgentLines(string[] agents)
        {
            //Take whole entry, return [0][1] (firstName lastName + status) "value i" + " " + "value ii" + 1
            var wholeAgent = new List<string>();
            for (int i = 0; i < agents.Length; i = i + 2)
            {
                var concatAgent = $"{agents[i]} {agents[i + 1]}";
                wholeAgent.Add(concatAgent);
            }
            return wholeAgent;       
        }


        public List<string> GetStringArray(string textBox)
        {
            string[] textToArray = textBox.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> agentsScheduled = new List<string>();
            foreach(string line in textToArray)
            {
                agentsScheduled.Add(line);                
            }
            return agentsScheduled;
        }

        public List<string> IsAbsent(List<string> agentScheduled, List<string> agentPresent)
        {

            
            List<string> isAbsent = new List<string>();
            foreach(string scheduled in agentScheduled)
            {
                bool isPresent = false; 
                foreach (string present in agentPresent)
                {

                    if(scheduled.ToLower() == present.ToLower())
                    {
                        isPresent = true;
                        break;
                    }
                }

                if(isPresent == false )
                {
                    isAbsent.Add(scheduled);
                }
            }
            return isAbsent;
        }

        public List<string> IsUncommitted(List<string> agentScheduled, List<string> agentPresent)
        {
            List<string> uncommitted = new List<string>();
            foreach(string present in agentPresent)
            {
                bool isCommitted = false;
                foreach (string scheduled in agentScheduled)
                {
                    if(present.ToLower() == scheduled.ToLower())
                    {
                        isCommitted = true;
                        break;
                    }

                }

                if(isCommitted == false)
                {
                    uncommitted.Add(present);
                }
            }
           
            return uncommitted;
        }
        public string DisplayAgents(List<string> isAbsent)
        {
            var absent = string.Join("\r\n", isAbsent);
            return absent; 
        }
    }
}
