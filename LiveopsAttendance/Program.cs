using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveopsAttendance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /// Create an array called scheduledAgents that holds lines
            ///create a loop that compares each line from scheduledAgents with the array of presentAgents
            ///if scheduledAgents.line == present Agents is truthy do nothing.
            ///else if scheduled agents.line != present agents console.Readline in tbAbsentAgents
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());


            
        }
    }
}
