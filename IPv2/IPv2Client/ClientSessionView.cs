using ErgometerApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPv2Client
{
    public class ClientSessionView : Panel
    {
        private System.Windows.Forms.Panel InstructionPanelContainer;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Panel InstructionPanelTutorial;
        private System.Windows.Forms.Panel InstructionPanelBottom;
        private System.Windows.Forms.Label TextTijd;
        private System.Windows.Forms.Button Button_StopTest;
        private System.Windows.Forms.Button Button_Logout;
        private System.Windows.Forms.Label LabelTijd;
        private System.Windows.Forms.Label TextHartslag;
        private System.Windows.Forms.Label LabelKCal;
        private System.Windows.Forms.Label TextEnergie;
        private System.Windows.Forms.Label LabelWatt;
        private System.Windows.Forms.Label TextTrapsterkte;
        public System.Windows.Forms.Label InstructionLabelText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer picturetimer;
        private MainWindow window;

        public ClientSessionView(MainWindow window): base()
        {
            this.window = window;
            this.picturetimer = new Timer();
            this.InstructionPanelContainer = new System.Windows.Forms.Panel();
            this.InstructionPanelTutorial = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InstructionPanelBottom = new System.Windows.Forms.Panel();
            this.InstructionLabelText = new System.Windows.Forms.Label();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.TextHartslag = new System.Windows.Forms.Label();
            this.LabelKCal = new System.Windows.Forms.Label();
            this.TextEnergie = new System.Windows.Forms.Label();
            this.LabelWatt = new System.Windows.Forms.Label();
            this.TextTrapsterkte = new System.Windows.Forms.Label();
            this.LabelTijd = new System.Windows.Forms.Label();
            this.TextTijd = new System.Windows.Forms.Label();
            this.Button_StopTest = new System.Windows.Forms.Button();
            this.Button_Logout = new System.Windows.Forms.Button();

            this.InstructionPanelContainer.SuspendLayout();
            this.InstructionPanelTutorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.InstructionPanelBottom.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // InstructionPanelContainer
            // 
            this.InstructionPanelContainer.Controls.Add(this.InstructionPanelTutorial);
            this.InstructionPanelContainer.Controls.Add(this.InstructionPanelBottom);
            this.InstructionPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstructionPanelContainer.Location = new System.Drawing.Point(300, 0);
            this.InstructionPanelContainer.Name = "InstructionPanelContainer";
            this.InstructionPanelContainer.Size = new System.Drawing.Size(484, 561);
            this.InstructionPanelContainer.TabIndex = 1;
            // 
            // InstructionPanelTutorial
            // 
            this.InstructionPanelTutorial.BackColor = System.Drawing.Color.White;
            this.InstructionPanelTutorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InstructionPanelTutorial.Controls.Add(this.pictureBox1);
            this.InstructionPanelTutorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstructionPanelTutorial.Location = new System.Drawing.Point(0, 0);
            this.InstructionPanelTutorial.Name = "InstructionPanelTutorial";
            this.InstructionPanelTutorial.Size = new System.Drawing.Size(484, 461);
            this.InstructionPanelTutorial.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::IPv2Client.Properties.Resources._1_the_catch;
            this.pictureBox1.Location = new System.Drawing.Point(57, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 188);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InstructionPanelBottom
            // 
            this.InstructionPanelBottom.Controls.Add(this.InstructionLabelText);
            this.InstructionPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InstructionPanelBottom.Location = new System.Drawing.Point(0, 461);
            this.InstructionPanelBottom.Name = "InstructionPanelBottom";
            this.InstructionPanelBottom.Size = new System.Drawing.Size(484, 100);
            this.InstructionPanelBottom.TabIndex = 0;
            // 
            // InstructionLabelText
            // 
            this.InstructionLabelText.BackColor = System.Drawing.Color.White;
            this.InstructionLabelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InstructionLabelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstructionLabelText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabelText.Location = new System.Drawing.Point(0, 0);
            this.InstructionLabelText.Name = "InstructionLabelText";
            this.InstructionLabelText.Padding = new System.Windows.Forms.Padding(5);
            this.InstructionLabelText.Size = new System.Drawing.Size(484, 100);
            this.InstructionLabelText.TabIndex = 0;
            this.InstructionLabelText.Text = "Start met roeien";
            // 
            // DataPanel
            // 
            this.DataPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataPanel.Controls.Add(new ChartPanel(ChartPanel.MetingType.HEARTBEAT, System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line, false));
            this.DataPanel.Controls.Add(this.TextHartslag);
            this.DataPanel.Controls.Add(this.LabelKCal);
            this.DataPanel.Controls.Add(this.TextEnergie);
            this.DataPanel.Controls.Add(this.LabelWatt);
            this.DataPanel.Controls.Add(this.TextTrapsterkte);
            this.DataPanel.Controls.Add(this.LabelTijd);
            this.DataPanel.Controls.Add(this.TextTijd);
            this.DataPanel.Controls.Add(this.Button_StopTest);
            this.DataPanel.Controls.Add(this.Button_Logout);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataPanel.Location = new System.Drawing.Point(0, 0);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(300, 561);
            this.DataPanel.TabIndex = 0;
            // 
            // TextHartslag
            // 
            this.TextHartslag.AutoSize = true;
            this.TextHartslag.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextHartslag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextHartslag.Location = new System.Drawing.Point(0, 204);
            this.TextHartslag.Name = "TextHartslag";
            this.TextHartslag.Size = new System.Drawing.Size(78, 21);
            this.TextHartslag.TabIndex = 8;
            this.TextHartslag.Text = "Hartslag:";
            // 
            // LabelKCal
            // 
            this.LabelKCal.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelKCal.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelKCal.Location = new System.Drawing.Point(0, 157);
            this.LabelKCal.Name = "LabelKCal";
            this.LabelKCal.Size = new System.Drawing.Size(298, 47);
            this.LabelKCal.TabIndex = 7;
            this.LabelKCal.Text = "100 KCal";
            this.LabelKCal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextEnergie
            // 
            this.TextEnergie.AutoSize = true;
            this.TextEnergie.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextEnergie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEnergie.Location = new System.Drawing.Point(0, 136);
            this.TextEnergie.Name = "TextEnergie";
            this.TextEnergie.Size = new System.Drawing.Size(72, 21);
            this.TextEnergie.TabIndex = 6;
            this.TextEnergie.Text = "Energie:";
            // 
            // LabelWatt
            // 
            this.LabelWatt.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelWatt.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWatt.Location = new System.Drawing.Point(0, 89);
            this.LabelWatt.Name = "LabelWatt";
            this.LabelWatt.Size = new System.Drawing.Size(298, 47);
            this.LabelWatt.TabIndex = 5;
            this.LabelWatt.Text = "300 W";
            this.LabelWatt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextTrapsterkte
            // 
            this.TextTrapsterkte.AutoSize = true;
            this.TextTrapsterkte.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextTrapsterkte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTrapsterkte.Location = new System.Drawing.Point(0, 68);
            this.TextTrapsterkte.Name = "TextTrapsterkte";
            this.TextTrapsterkte.Size = new System.Drawing.Size(99, 21);
            this.TextTrapsterkte.TabIndex = 4;
            this.TextTrapsterkte.Text = "Trapsterkte:";
            // 
            // LabelTijd
            // 
            this.LabelTijd.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTijd.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTijd.Location = new System.Drawing.Point(0, 21);
            this.LabelTijd.Name = "LabelTijd";
            this.LabelTijd.Size = new System.Drawing.Size(298, 47);
            this.LabelTijd.TabIndex = 3;
            this.LabelTijd.Text = "00:00:00";
            this.LabelTijd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextTijd
            // 
            this.TextTijd.AutoSize = true;
            this.TextTijd.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextTijd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTijd.Location = new System.Drawing.Point(0, 0);
            this.TextTijd.Name = "TextTijd";
            this.TextTijd.Size = new System.Drawing.Size(43, 21);
            this.TextTijd.TabIndex = 2;
            this.TextTijd.Text = "Tijd:";
            // 
            // Button_StopTest
            // 
            this.Button_StopTest.BackColor = System.Drawing.Color.Red;
            this.Button_StopTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button_StopTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_StopTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StopTest.ForeColor = System.Drawing.Color.White;
            this.Button_StopTest.Location = new System.Drawing.Point(0, 477);
            this.Button_StopTest.Name = "Button_StopTest";
            this.Button_StopTest.Size = new System.Drawing.Size(298, 41);
            this.Button_StopTest.TabIndex = 1;
            this.Button_StopTest.Text = "Stop Test";
            this.Button_StopTest.UseVisualStyleBackColor = false;
            this.Button_StopTest.Click += new System.EventHandler(this.Button_StopTest_Click);
            // 
            // Button_Logout
            // 
            this.Button_Logout.BackColor = System.Drawing.Color.Gray;
            this.Button_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Logout.ForeColor = System.Drawing.Color.White;
            this.Button_Logout.Location = new System.Drawing.Point(0, 518);
            this.Button_Logout.Name = "Button_Logout";
            this.Button_Logout.Size = new System.Drawing.Size(298, 41);
            this.Button_Logout.TabIndex = 0;
            this.Button_Logout.Text = "Uitloggen";
            this.Button_Logout.UseVisualStyleBackColor = false;
            this.Button_Logout.Click += new System.EventHandler(this.Button_Logout_Click);
            // 
            // picturetimer
            // 
            this.picturetimer.Tick += new System.EventHandler(this.picturetimer_Tick);
            picturetimer.Interval = 1000;
            picturetimer.Start();
            // 
            // MainContainer
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.InstructionPanelContainer);
            this.Controls.Add(this.DataPanel);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MainContainer";
            this.Size = new System.Drawing.Size(784, 561);
            this.TabIndex = 0;

            this.ResumeLayout(false);
            this.InstructionPanelContainer.ResumeLayout(false);
            this.InstructionPanelTutorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.InstructionPanelBottom.ResumeLayout(false);
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
        }

        private void Button_Logout_Click(object sender, EventArgs e)
        {
            window.LoginContainer.Visible = true;
            window.clientSessionView.Visible = false;
            window.LoginContainer.BringToFront();
        }

        private void Button_StopTest_Click(object sender, EventArgs e)
        {

        }

        private int ticks = 0;

        private void picturetimer_Tick(object sender, EventArgs e)
        {
            if (ticks > 3)
                ticks = 0;

            switch (ticks)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources._1_the_catch;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources._2_the_drive;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._3_the_finish;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._4_the_recovery;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources._1_the_catch;
                    break;
            }

            ticks++;

        }
    }
   
}
