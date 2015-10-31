using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPv2Dokter
{
    public class ClientSummaryPanel : Panel
    {
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label NaamLabel;

        public ClientSummaryPanel(): base()
        {
            this.DurationLabel = new Label();
            this.TimeLabel = new Label();
            this.DateLabel = new Label();
            this.NaamLabel = new Label();
            // 
            // NaamLabel
            // 
            this.NaamLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.NaamLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NaamLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaamLabel.ForeColor = System.Drawing.Color.White;
            this.NaamLabel.Location = new System.Drawing.Point(0, 0);
            this.NaamLabel.Name = "label1";
            this.NaamLabel.Padding = new System.Windows.Forms.Padding(2);
            this.NaamLabel.Size = new System.Drawing.Size(148, 50);
            this.NaamLabel.TabIndex = 0;
            this.NaamLabel.Text = "<Naam Client>";
            this.NaamLabel.MouseClick += ClientSummaryPanel_MouseClick;
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(0, 50);
            this.DateLabel.Name = "label2";
            this.DateLabel.Padding = new System.Windows.Forms.Padding(2);
            this.DateLabel.Size = new System.Drawing.Size(148, 30);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Date:";
            this.DateLabel.MouseClick += ClientSummaryPanel_MouseClick;
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(0, 80);
            this.TimeLabel.Name = "label3";
            this.TimeLabel.Padding = new System.Windows.Forms.Padding(2);
            this.TimeLabel.Size = new System.Drawing.Size(148, 30);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "Time:";
            this.TimeLabel.MouseClick += ClientSummaryPanel_MouseClick;
            // 
            // DurationLabel
            // 
            this.DurationLabel.BackColor = System.Drawing.Color.Transparent;
            this.DurationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DurationLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.DurationLabel.ForeColor = System.Drawing.Color.White;
            this.DurationLabel.Location = new System.Drawing.Point(0, 110);
            this.DurationLabel.Name = "label4";
            this.DurationLabel.Padding = new System.Windows.Forms.Padding(2);
            this.DurationLabel.Size = new System.Drawing.Size(148, 30);
            this.DurationLabel.TabIndex = 3;
            this.DurationLabel.Text = "Duration:";
            this.DurationLabel.MouseClick += ClientSummaryPanel_MouseClick;
            // 
            // This
            // 
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.NaamLabel);
            this.Location = new System.Drawing.Point(8, 8);
            this.Name = "summary container";
            this.Size = new System.Drawing.Size(150, 150);
            this.MouseClick += ClientSummaryPanel_MouseClick;
        }

        private void ClientSummaryPanel_MouseClick(object sender, MouseEventArgs e)
        {
            new SessionWindow().Visible = true;
            TimeLabel.Text = "Time: 00:30";
        }
    }
}
