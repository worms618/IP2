using ErgometerApplication;

namespace IPv2Client
{
    partial class MainWindow
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
            this.LoginContainer = new System.Windows.Forms.Panel();
            this.clientSessionView = new ClientSessionView(this);
            this.clientSessionView.Visible = false;
            this.naamText = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.LoginContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginContainer
            // 
            this.LoginContainer.BackColor = System.Drawing.Color.White;
            this.LoginContainer.Controls.Add(this.loginButton);
            this.LoginContainer.Controls.Add(this.richTextBox1);
            this.LoginContainer.Controls.Add(this.naamText);
            this.LoginContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginContainer.Location = new System.Drawing.Point(0, 0);
            this.LoginContainer.Name = "LoginContainer";
            this.LoginContainer.Size = new System.Drawing.Size(784, 561);
            this.LoginContainer.TabIndex = 0;
            // 
            // naamText
            // 
            this.naamText.AutoSize = true;
            this.naamText.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naamText.Location = new System.Drawing.Point(257, 170);
            this.naamText.Name = "naamText";
            this.naamText.Size = new System.Drawing.Size(55, 21);
            this.naamText.TabIndex = 0;
            this.naamText.Text = "Naam:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richTextBox1.Location = new System.Drawing.Point(261, 206);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(273, 29);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LimeGreen;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(261, 263);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(273, 50);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "START TEST";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.LoginContainer);
            this.Controls.Add(this.clientSessionView);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.Text = "Ergometer Roei Applicatie";
            this.LoginContainer.ResumeLayout(false);
            this.LoginContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public ClientSessionView clientSessionView;
        public System.Windows.Forms.Panel LoginContainer;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label naamText;
    }
}

