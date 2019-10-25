namespace LiveopsAttendance
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbScheduledAgents = new System.Windows.Forms.TextBox();
            this.tbAgentsPresent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.tbAgentsAbsent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUncommitted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbScheduledAgents
            // 
            this.tbScheduledAgents.Location = new System.Drawing.Point(92, 148);
            this.tbScheduledAgents.Margin = new System.Windows.Forms.Padding(6);
            this.tbScheduledAgents.Multiline = true;
            this.tbScheduledAgents.Name = "tbScheduledAgents";
            this.tbScheduledAgents.Size = new System.Drawing.Size(326, 691);
            this.tbScheduledAgents.TabIndex = 0;
            this.tbScheduledAgents.TextChanged += new System.EventHandler(this.TbScheduledAgents_TextChanged);
            // 
            // tbAgentsPresent
            // 
            this.tbAgentsPresent.Location = new System.Drawing.Point(490, 148);
            this.tbAgentsPresent.Margin = new System.Windows.Forms.Padding(6);
            this.tbAgentsPresent.Multiline = true;
            this.tbAgentsPresent.Name = "tbAgentsPresent";
            this.tbAgentsPresent.Size = new System.Drawing.Size(326, 691);
            this.tbAgentsPresent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scheduled Agents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agents Present";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.Location = new System.Drawing.Point(883, 91);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(6);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(327, 52);
            this.btnAnalyze.TabIndex = 4;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // tbAgentsAbsent
            // 
            this.tbAgentsAbsent.Location = new System.Drawing.Point(884, 310);
            this.tbAgentsAbsent.Margin = new System.Windows.Forms.Padding(6);
            this.tbAgentsAbsent.Multiline = true;
            this.tbAgentsAbsent.Name = "tbAgentsAbsent";
            this.tbAgentsAbsent.Size = new System.Drawing.Size(326, 529);
            this.tbAgentsAbsent.TabIndex = 5;
            this.tbAgentsAbsent.TextChanged += new System.EventHandler(this.TbAgentsAbsent_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(876, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Agents Absent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(533, 63);
            this.label4.TabIndex = 7;
            this.label4.Text = "Liveops Absents App";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(883, 155);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(327, 52);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1236, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Agents Uncommitted";
            // 
            // tbUncommitted
            // 
            this.tbUncommitted.Location = new System.Drawing.Point(1244, 310);
            this.tbUncommitted.Margin = new System.Windows.Forms.Padding(6);
            this.tbUncommitted.Multiline = true;
            this.tbUncommitted.Name = "tbUncommitted";
            this.tbUncommitted.Size = new System.Drawing.Size(326, 529);
            this.tbUncommitted.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 894);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUncommitted);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAgentsAbsent);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAgentsPresent);
            this.Controls.Add(this.tbScheduledAgents);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Liveops Attendance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbScheduledAgents;
        private System.Windows.Forms.TextBox tbAgentsPresent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.TextBox tbAgentsAbsent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUncommitted;
    }
}

