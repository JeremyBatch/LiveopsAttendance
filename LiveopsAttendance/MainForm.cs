using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveopsAttendance
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var lines = new string[] 
            //{ 
            //    "Same Smith On Call",
            //    "Patty Peet Available",
            //    "Burt Bee Hold"
            //};

            //// These people are supposed to be here
            //var scheduled = new List<Agent>();
            //// These people are actually here (sched or not)
            //var present = new List<Agent>();

            //var uncommitted = present.Where(p => !scheduled.Any(s => s.Name == p.Name) && p.Status != Status.OnCall);

            //var absent = scheduled.Where(s => !present.Any(p => p.Name == s.Name));
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            AnalyzerProcessor ap = new AnalyzerProcessor();
            var scheduledAgents = ap.GetAgents(tbScheduledAgents.Text);
            var presentAgents = ap.GetAgents(tbAgentsPresent.Text, false);

            var uncommitted = presentAgents.Where(p => !scheduledAgents.Any(s => s.Name == p.Name) && p.Status != Status.OnCall);
            var absent = scheduledAgents.Where(s => !presentAgents.Any(p => p.Name == s.Name));

            tbAgentsAbsent.Text = ap.DisplayAgents(absent.Select(a => a.Name).ToList());
            tbUncommitted.Text = ap.DisplayAgents(uncommitted.Select(a => a.Name).ToList());
         
        }

        private void TbAgentsAbsent_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            tbScheduledAgents.Clear();
            tbAgentsPresent.Clear();
            tbAgentsAbsent.Clear();
            tbUncommitted.Clear();            
        }

        private void TbScheduledAgents_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
