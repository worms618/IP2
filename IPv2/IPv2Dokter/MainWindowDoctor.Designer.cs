namespace IPv2Dokter
{
    partial class MainWindowDoctor
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
            this.OverviewContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OverviewContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OverviewContainer
            // 
            this.OverviewContainer.BackColor = System.Drawing.Color.White;
            this.OverviewContainer.Controls.Add(this.flowLayoutPanel1);
            this.OverviewContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverviewContainer.Location = new System.Drawing.Point(0, 0);
            this.OverviewContainer.Name = "OverviewContainer";
            this.OverviewContainer.Size = new System.Drawing.Size(784, 561);
            this.OverviewContainer.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(new ClientSummaryPanel());
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.flowLayoutPanel1.TabIndex = 0;

            // 
            // MainWindowDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.OverviewContainer);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindowDoctor";
            this.Text = "Overzicht Sessie Geschiedenis";
            this.OverviewContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OverviewContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    }
}

