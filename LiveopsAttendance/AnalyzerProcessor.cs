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
        private Agent ParseLine(string line)
        {
            var parts = line.Split(' ');
            var status = string.Join("", parts.Where((s, i) => i > 1).Select(s => s).ToArray());
            return new Agent
            {
                Name = $"{parts[0]} {parts[1]}",
                Status = status.Length > 0 ? (Status)Enum.Parse(typeof(Status), status, true) : Status.Unknown
            };
        }

        public List<Agent> GetAgents(string text)
        {
            var textToArray = text.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            var results = new List<Agent>();
            foreach(var line in textToArray)
            {
                results.Add(ParseLine(line));
            }
            return results;
        }

        public List<string> GetStringArray(string textBox)
        {
            string[] textToArray = textBox.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> agentsScheduled = new List<string>();
            foreach(string line in textToArray)
            {
                //if (line == "")
                //{
                //    continue;
                //}
                
             
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
