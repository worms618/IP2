using System.IO.Ports;

namespace ErgometerSimulator
{
    partial class ErgometerSimulator
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
            this.components = new System.ComponentModel.Container();
            this.connectButton = new System.Windows.Forms.Button();
            this.ComPortBox = new System.Windows.Forms.ComboBox();
            this.labelHeartBeat = new System.Windows.Forms.Label();
            this.randomHeartBeat = new System.Windows.Forms.CheckBox();
            this.text1HeartBeat = new System.Windows.Forms.TextBox();
            this.text2HeartBeat = new System.Windows.Forms.TextBox();
            this.setHeartBeat = new System.Windows.Forms.Button();
            this.setRPM = new System.Windows.Forms.Button();
            this.text2RPM = new System.Windows.Forms.TextBox();
            this.text1RPM = new System.Windows.Forms.TextBox();
            this.randomRPM = new System.Windows.Forms.CheckBox();
            this.labelRPM = new System.Windows.Forms.Label();
            this.setSpeed = new System.Windows.Forms.Button();
            this.text2Speed = new System.Windows.Forms.TextBox();
            this.text1Speed = new System.Windows.Forms.TextBox();
            this.randomSpeed = new System.Windows.Forms.CheckBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.setDistance = new System.Windows.Forms.Button();
            this.text2Distance = new System.Windows.Forms.TextBox();
            this.text1Distance = new System.Windows.Forms.TextBox();
            this.randomDistance = new System.Windows.Forms.CheckBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.setPower = new System.Windows.Forms.Button();
            this.text2Power = new System.Windows.Forms.TextBox();
            this.text1Power = new System.Windows.Forms.TextBox();
            this.randomPower = new System.Windows.Forms.CheckBox();
            this.labelPower = new System.Windows.Forms.Label();
            this.setEnergy = new System.Windows.Forms.Button();
            this.text2Energy = new System.Windows.Forms.TextBox();
            this.text1Energy = new System.Windows.Forms.TextBox();
            this.randomEnergy = new System.Windows.Forms.CheckBox();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.setActualPower = new System.Windows.Forms.Button();
            this.text2ActualPower = new System.Windows.Forms.TextBox();
            this.text1ActualPower = new System.Windows.Forms.TextBox();
            this.randomActualPower = new System.Windows.Forms.CheckBox();
            this.labelActualPower = new System.Windows.Forms.Label();
            this.setTime = new System.Windows.Forms.Button();
            this.text1Time = new System.Windows.Forms.TextBox();
            this.countTime = new System.Windows.Forms.CheckBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.heartbeatMinLbl = new System.Windows.Forms.Label();
            this.heartbeatMaxLbl = new System.Windows.Forms.Label();
            this.rpmMinLbl = new System.Windows.Forms.Label();
            this.rpmMaxLbl = new System.Windows.Forms.Label();
            this.speedMinLbl = new System.Windows.Forms.Label();
            this.speedMaxLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.heartbeatCurLbl = new System.Windows.Forms.Label();
            this.rpmCurLbl = new System.Windows.Forms.Label();
            this.speedCurLbl = new System.Windows.Forms.Label();
            this.distanceMinLbl = new System.Windows.Forms.Label();
            this.distanceMaxLbl = new System.Windows.Forms.Label();
            this.distanceCurLbl = new System.Windows.Forms.Label();
            this.powerMinLbl = new System.Windows.Forms.Label();
            this.powerMaxLbl = new System.Windows.Forms.Label();
            this.powerCurLbl = new System.Windows.Forms.Label();
            this.energyMinLbl = new System.Windows.Forms.Label();
            this.energyMaxLbl = new System.Windows.Forms.Label();
            this.energyCurLbl = new System.Windows.Forms.Label();
            this.actpowerMinLbl = new System.Windows.Forms.Label();
            this.actpowerMaxLbl = new System.Windows.Forms.Label();
            this.actpowerCurLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(113, 248);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(76, 22);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // ComPortBox
            // 
            this.ComPortBox.FormattingEnabled = true;
            this.ComPortBox.Items.AddRange(SerialPort.GetPortNames());
            if (ComPortBox.Items.Count > 0)
                this.ComPortBox.SelectedIndex = 0;
            if (ComPortBox.Items.Count > 1)
                this.ComPortBox.SelectedIndex = 1;
            this.ComPortBox.Location = new System.Drawing.Point(11, 250);
            this.ComPortBox.Margin = new System.Windows.Forms.Padding(2);
            this.ComPortBox.Name = "ComPortBox";
            this.ComPortBox.Size = new System.Drawing.Size(92, 21);
            this.ComPortBox.TabIndex = 1;
            // 
            // labelHeartBeat
            // 
            this.labelHeartBeat.AutoSize = true;
            this.labelHeartBeat.Location = new System.Drawing.Point(9, 22);
            this.labelHeartBeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeartBeat.Name = "labelHeartBeat";
            this.labelHeartBeat.Size = new System.Drawing.Size(54, 13);
            this.labelHeartBeat.TabIndex = 2;
            this.labelHeartBeat.Text = "Heartbeat";
            // 
            // randomHeartBeat
            // 
            this.randomHeartBeat.AutoSize = true;
            this.randomHeartBeat.Enabled = false;
            this.randomHeartBeat.Location = new System.Drawing.Point(86, 23);
            this.randomHeartBeat.Margin = new System.Windows.Forms.Padding(2);
            this.randomHeartBeat.Name = "randomHeartBeat";
            this.randomHeartBeat.Size = new System.Drawing.Size(15, 14);
            this.randomHeartBeat.TabIndex = 3;
            this.randomHeartBeat.UseVisualStyleBackColor = true;
            this.randomHeartBeat.CheckedChanged += new System.EventHandler(this.randomHeartBeat_CheckedChanged);
            // 
            // text1HeartBeat
            // 
            this.text1HeartBeat.Enabled = false;
            this.text1HeartBeat.Location = new System.Drawing.Point(113, 20);
            this.text1HeartBeat.Margin = new System.Windows.Forms.Padding(2);
            this.text1HeartBeat.Name = "text1HeartBeat";
            this.text1HeartBeat.Size = new System.Drawing.Size(76, 20);
            this.text1HeartBeat.TabIndex = 4;
            // 
            // text2HeartBeat
            // 
            this.text2HeartBeat.Enabled = false;
            this.text2HeartBeat.Location = new System.Drawing.Point(193, 20);
            this.text2HeartBeat.Margin = new System.Windows.Forms.Padding(2);
            this.text2HeartBeat.Name = "text2HeartBeat";
            this.text2HeartBeat.Size = new System.Drawing.Size(76, 20);
            this.text2HeartBeat.TabIndex = 5;
            // 
            // setHeartBeat
            // 
            this.setHeartBeat.Enabled = false;
            this.setHeartBeat.Location = new System.Drawing.Point(272, 20);
            this.setHeartBeat.Margin = new System.Windows.Forms.Padding(2);
            this.setHeartBeat.Name = "setHeartBeat";
            this.setHeartBeat.Size = new System.Drawing.Size(56, 19);
            this.setHeartBeat.TabIndex = 6;
            this.setHeartBeat.Text = "Set";
            this.setHeartBeat.UseVisualStyleBackColor = true;
            this.setHeartBeat.Click += new System.EventHandler(this.setHeartBeat_Click);
            // 
            // setRPM
            // 
            this.setRPM.Enabled = false;
            this.setRPM.Location = new System.Drawing.Point(272, 41);
            this.setRPM.Margin = new System.Windows.Forms.Padding(2);
            this.setRPM.Name = "setRPM";
            this.setRPM.Size = new System.Drawing.Size(56, 19);
            this.setRPM.TabIndex = 11;
            this.setRPM.Text = "Set";
            this.setRPM.UseVisualStyleBackColor = true;
            this.setRPM.Click += new System.EventHandler(this.setRPM_Click);
            // 
            // text2RPM
            // 
            this.text2RPM.Enabled = false;
            this.text2RPM.Location = new System.Drawing.Point(193, 41);
            this.text2RPM.Margin = new System.Windows.Forms.Padding(2);
            this.text2RPM.Name = "text2RPM";
            this.text2RPM.Size = new System.Drawing.Size(76, 20);
            this.text2RPM.TabIndex = 10;
            // 
            // text1RPM
            // 
            this.text1RPM.Enabled = false;
            this.text1RPM.Location = new System.Drawing.Point(113, 41);
            this.text1RPM.Margin = new System.Windows.Forms.Padding(2);
            this.text1RPM.Name = "text1RPM";
            this.text1RPM.Size = new System.Drawing.Size(76, 20);
            this.text1RPM.TabIndex = 9;
            // 
            // randomRPM
            // 
            this.randomRPM.AutoSize = true;
            this.randomRPM.Enabled = false;
            this.randomRPM.Location = new System.Drawing.Point(86, 44);
            this.randomRPM.Margin = new System.Windows.Forms.Padding(2);
            this.randomRPM.Name = "randomRPM";
            this.randomRPM.Size = new System.Drawing.Size(15, 14);
            this.randomRPM.TabIndex = 8;
            this.randomRPM.UseVisualStyleBackColor = true;
            this.randomRPM.CheckedChanged += new System.EventHandler(this.randomRPM_CheckedChanged);
            // 
            // labelRPM
            // 
            this.labelRPM.AutoSize = true;
            this.labelRPM.Location = new System.Drawing.Point(9, 43);
            this.labelRPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRPM.Name = "labelRPM";
            this.labelRPM.Size = new System.Drawing.Size(31, 13);
            this.labelRPM.TabIndex = 7;
            this.labelRPM.Text = "RPM";
            // 
            // setSpeed
            // 
            this.setSpeed.Enabled = false;
            this.setSpeed.Location = new System.Drawing.Point(272, 63);
            this.setSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.setSpeed.Name = "setSpeed";
            this.setSpeed.Size = new System.Drawing.Size(56, 19);
            this.setSpeed.TabIndex = 16;
            this.setSpeed.Text = "Set";
            this.setSpeed.UseVisualStyleBackColor = true;
            this.setSpeed.Click += new System.EventHandler(this.setSpeed_Click);
            // 
            // text2Speed
            // 
            this.text2Speed.Enabled = false;
            this.text2Speed.Location = new System.Drawing.Point(193, 63);
            this.text2Speed.Margin = new System.Windows.Forms.Padding(2);
            this.text2Speed.Name = "text2Speed";
            this.text2Speed.Size = new System.Drawing.Size(76, 20);
            this.text2Speed.TabIndex = 15;
            // 
            // text1Speed
            // 
            this.text1Speed.Enabled = false;
            this.text1Speed.Location = new System.Drawing.Point(113, 63);
            this.text1Speed.Margin = new System.Windows.Forms.Padding(2);
            this.text1Speed.Name = "text1Speed";
            this.text1Speed.Size = new System.Drawing.Size(76, 20);
            this.text1Speed.TabIndex = 14;
            // 
            // randomSpeed
            // 
            this.randomSpeed.AutoSize = true;
            this.randomSpeed.Enabled = false;
            this.randomSpeed.Location = new System.Drawing.Point(86, 67);
            this.randomSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.randomSpeed.Name = "randomSpeed";
            this.randomSpeed.Size = new System.Drawing.Size(15, 14);
            this.randomSpeed.TabIndex = 13;
            this.randomSpeed.UseVisualStyleBackColor = true;
            this.randomSpeed.CheckedChanged += new System.EventHandler(this.randomSpeed_CheckedChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(9, 66);
            this.labelSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(38, 13);
            this.labelSpeed.TabIndex = 12;
            this.labelSpeed.Text = "Speed";
            // 
            // setDistance
            // 
            this.setDistance.Enabled = false;
            this.setDistance.Location = new System.Drawing.Point(272, 88);
            this.setDistance.Margin = new System.Windows.Forms.Padding(2);
            this.setDistance.Name = "setDistance";
            this.setDistance.Size = new System.Drawing.Size(56, 19);
            this.setDistance.TabIndex = 21;
            this.setDistance.Text = "Set";
            this.setDistance.UseVisualStyleBackColor = true;
            this.setDistance.Click += new System.EventHandler(this.setDistance_Click);
            // 
            // text2Distance
            // 
            this.text2Distance.Enabled = false;
            this.text2Distance.Location = new System.Drawing.Point(193, 88);
            this.text2Distance.Margin = new System.Windows.Forms.Padding(2);
            this.text2Distance.Name = "text2Distance";
            this.text2Distance.Size = new System.Drawing.Size(76, 20);
            this.text2Distance.TabIndex = 20;
            // 
            // text1Distance
            // 
            this.text1Distance.Enabled = false;
            this.text1Distance.Location = new System.Drawing.Point(113, 88);
            this.text1Distance.Margin = new System.Windows.Forms.Padding(2);
            this.text1Distance.Name = "text1Distance";
            this.text1Distance.Size = new System.Drawing.Size(76, 20);
            this.text1Distance.TabIndex = 19;
            // 
            // randomDistance
            // 
            this.randomDistance.AutoSize = true;
            this.randomDistance.Enabled = false;
            this.randomDistance.Location = new System.Drawing.Point(86, 91);
            this.randomDistance.Margin = new System.Windows.Forms.Padding(2);
            this.randomDistance.Name = "randomDistance";
            this.randomDistance.Size = new System.Drawing.Size(15, 14);
            this.randomDistance.TabIndex = 18;
            this.randomDistance.UseVisualStyleBackColor = true;
            this.randomDistance.CheckedChanged += new System.EventHandler(this.randomDistance_CheckedChanged);
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(9, 90);
            this.labelDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(49, 13);
            this.labelDistance.TabIndex = 17;
            this.labelDistance.Text = "Distance";
            // 
            // setPower
            // 
            this.setPower.Enabled = false;
            this.setPower.Location = new System.Drawing.Point(272, 111);
            this.setPower.Margin = new System.Windows.Forms.Padding(2);
            this.setPower.Name = "setPower";
            this.setPower.Size = new System.Drawing.Size(56, 19);
            this.setPower.TabIndex = 26;
            this.setPower.Text = "Set";
            this.setPower.UseVisualStyleBackColor = true;
            this.setPower.Click += new System.EventHandler(this.setPower_Click);
            // 
            // text2Power
            // 
            this.text2Power.Enabled = false;
            this.text2Power.Location = new System.Drawing.Point(193, 111);
            this.text2Power.Margin = new System.Windows.Forms.Padding(2);
            this.text2Power.Name = "text2Power";
            this.text2Power.Size = new System.Drawing.Size(76, 20);
            this.text2Power.TabIndex = 25;
            // 
            // text1Power
            // 
            this.text1Power.Enabled = false;
            this.text1Power.Location = new System.Drawing.Point(113, 111);
            this.text1Power.Margin = new System.Windows.Forms.Padding(2);
            this.text1Power.Name = "text1Power";
            this.text1Power.Size = new System.Drawing.Size(76, 20);
            this.text1Power.TabIndex = 24;
            // 
            // randomPower
            // 
            this.randomPower.AutoSize = true;
            this.randomPower.Enabled = false;
            this.randomPower.Location = new System.Drawing.Point(86, 115);
            this.randomPower.Margin = new System.Windows.Forms.Padding(2);
            this.randomPower.Name = "randomPower";
            this.randomPower.Size = new System.Drawing.Size(15, 14);
            this.randomPower.TabIndex = 23;
            this.randomPower.UseVisualStyleBackColor = true;
            this.randomPower.CheckedChanged += new System.EventHandler(this.randomPower_CheckedChanged);
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(9, 114);
            this.labelPower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(37, 13);
            this.labelPower.TabIndex = 22;
            this.labelPower.Text = "Power";
            // 
            // setEnergy
            // 
            this.setEnergy.Enabled = false;
            this.setEnergy.Location = new System.Drawing.Point(272, 135);
            this.setEnergy.Margin = new System.Windows.Forms.Padding(2);
            this.setEnergy.Name = "setEnergy";
            this.setEnergy.Size = new System.Drawing.Size(56, 19);
            this.setEnergy.TabIndex = 31;
            this.setEnergy.Text = "Set";
            this.setEnergy.UseVisualStyleBackColor = true;
            this.setEnergy.Click += new System.EventHandler(this.setEnergy_Click);
            // 
            // text2Energy
            // 
            this.text2Energy.Enabled = false;
            this.text2Energy.Location = new System.Drawing.Point(193, 135);
            this.text2Energy.Margin = new System.Windows.Forms.Padding(2);
            this.text2Energy.Name = "text2Energy";
            this.text2Energy.Size = new System.Drawing.Size(76, 20);
            this.text2Energy.TabIndex = 30;
            // 
            // text1Energy
            // 
            this.text1Energy.Enabled = false;
            this.text1Energy.Location = new System.Drawing.Point(113, 135);
            this.text1Energy.Margin = new System.Windows.Forms.Padding(2);
            this.text1Energy.Name = "text1Energy";
            this.text1Energy.Size = new System.Drawing.Size(76, 20);
            this.text1Energy.TabIndex = 29;
            // 
            // randomEnergy
            // 
            this.randomEnergy.AutoSize = true;
            this.randomEnergy.Enabled = false;
            this.randomEnergy.Location = new System.Drawing.Point(86, 138);
            this.randomEnergy.Margin = new System.Windows.Forms.Padding(2);
            this.randomEnergy.Name = "randomEnergy";
            this.randomEnergy.Size = new System.Drawing.Size(15, 14);
            this.randomEnergy.TabIndex = 28;
            this.randomEnergy.UseVisualStyleBackColor = true;
            this.randomEnergy.CheckedChanged += new System.EventHandler(this.randomEnergy_CheckedChanged);
            // 
            // labelEnergy
            // 
            this.labelEnergy.AutoSize = true;
            this.labelEnergy.Location = new System.Drawing.Point(9, 137);
            this.labelEnergy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(40, 13);
            this.labelEnergy.TabIndex = 27;
            this.labelEnergy.Text = "Energy";
            // 
            // setActualPower
            // 
            this.setActualPower.Enabled = false;
            this.setActualPower.Location = new System.Drawing.Point(272, 159);
            this.setActualPower.Margin = new System.Windows.Forms.Padding(2);
            this.setActualPower.Name = "setActualPower";
            this.setActualPower.Size = new System.Drawing.Size(56, 19);
            this.setActualPower.TabIndex = 36;
            this.setActualPower.Text = "Set";
            this.setActualPower.UseVisualStyleBackColor = true;
            this.setActualPower.Click += new System.EventHandler(this.setActualPower_Click);
            // 
            // text2ActualPower
            // 
            this.text2ActualPower.Enabled = false;
            this.text2ActualPower.Location = new System.Drawing.Point(193, 159);
            this.text2ActualPower.Margin = new System.Windows.Forms.Padding(2);
            this.text2ActualPower.Name = "text2ActualPower";
            this.text2ActualPower.Size = new System.Drawing.Size(76, 20);
            this.text2ActualPower.TabIndex = 35;
            // 
            // text1ActualPower
            // 
            this.text1ActualPower.Enabled = false;
            this.text1ActualPower.Location = new System.Drawing.Point(113, 159);
            this.text1ActualPower.Margin = new System.Windows.Forms.Padding(2);
            this.text1ActualPower.Name = "text1ActualPower";
            this.text1ActualPower.Size = new System.Drawing.Size(76, 20);
            this.text1ActualPower.TabIndex = 34;
            // 
            // randomActualPower
            // 
            this.randomActualPower.AutoSize = true;
            this.randomActualPower.Enabled = false;
            this.randomActualPower.Location = new System.Drawing.Point(86, 162);
            this.randomActualPower.Margin = new System.Windows.Forms.Padding(2);
            this.randomActualPower.Name = "randomActualPower";
            this.randomActualPower.Size = new System.Drawing.Size(15, 14);
            this.randomActualPower.TabIndex = 33;
            this.randomActualPower.UseVisualStyleBackColor = true;
            this.randomActualPower.CheckedChanged += new System.EventHandler(this.randomActualPower_CheckedChanged);
            // 
            // labelActualPower
            // 
            this.labelActualPower.AutoSize = true;
            this.labelActualPower.Location = new System.Drawing.Point(9, 162);
            this.labelActualPower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActualPower.Name = "labelActualPower";
            this.labelActualPower.Size = new System.Drawing.Size(70, 13);
            this.labelActualPower.TabIndex = 32;
            this.labelActualPower.Text = "Actual Power";
            // 
            // setTime
            // 
            this.setTime.Enabled = false;
            this.setTime.Location = new System.Drawing.Point(272, 213);
            this.setTime.Margin = new System.Windows.Forms.Padding(2);
            this.setTime.Name = "setTime";
            this.setTime.Size = new System.Drawing.Size(56, 19);
            this.setTime.TabIndex = 41;
            this.setTime.Text = "Set";
            this.setTime.UseVisualStyleBackColor = true;
            this.setTime.Click += new System.EventHandler(this.setTime_Click);
            // 
            // text1Time
            // 
            this.text1Time.Enabled = false;
            this.text1Time.Location = new System.Drawing.Point(113, 213);
            this.text1Time.Margin = new System.Windows.Forms.Padding(2);
            this.text1Time.Name = "text1Time";
            this.text1Time.Size = new System.Drawing.Size(77, 20);
            this.text1Time.TabIndex = 39;
            // 
            // countTime
            // 
            this.countTime.AutoSize = true;
            this.countTime.Enabled = false;
            this.countTime.Location = new System.Drawing.Point(58, 214);
            this.countTime.Margin = new System.Windows.Forms.Padding(2);
            this.countTime.Name = "countTime";
            this.countTime.Size = new System.Drawing.Size(54, 17);
            this.countTime.TabIndex = 38;
            this.countTime.Text = "Down";
            this.countTime.UseVisualStyleBackColor = true;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(9, 215);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(30, 13);
            this.labelTime.TabIndex = 37;
            this.labelTime.Text = "Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Random";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(111, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Min";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(190, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Name";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Location = new System.Drawing.Point(194, 214);
            this.labelCurrentTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(34, 13);
            this.labelCurrentTime.TabIndex = 49;
            this.labelCurrentTime.Text = "00:00";
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 200;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // heartbeatMinLbl
            // 
            this.heartbeatMinLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heartbeatMinLbl.AutoSize = true;
            this.heartbeatMinLbl.Location = new System.Drawing.Point(334, 24);
            this.heartbeatMinLbl.Name = "heartbeatMinLbl";
            this.heartbeatMinLbl.Size = new System.Drawing.Size(13, 13);
            this.heartbeatMinLbl.TabIndex = 50;
            this.heartbeatMinLbl.Text = "0";
            // 
            // heartbeatMaxLbl
            // 
            this.heartbeatMaxLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heartbeatMaxLbl.AutoSize = true;
            this.heartbeatMaxLbl.Location = new System.Drawing.Point(366, 23);
            this.heartbeatMaxLbl.Name = "heartbeatMaxLbl";
            this.heartbeatMaxLbl.Size = new System.Drawing.Size(13, 13);
            this.heartbeatMaxLbl.TabIndex = 51;
            this.heartbeatMaxLbl.Text = "0";
            // 
            // rpmMinLbl
            // 
            this.rpmMinLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rpmMinLbl.AutoSize = true;
            this.rpmMinLbl.Location = new System.Drawing.Point(334, 47);
            this.rpmMinLbl.Name = "rpmMinLbl";
            this.rpmMinLbl.Size = new System.Drawing.Size(13, 13);
            this.rpmMinLbl.TabIndex = 52;
            this.rpmMinLbl.Text = "0";
            // 
            // rpmMaxLbl
            // 
            this.rpmMaxLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rpmMaxLbl.AutoSize = true;
            this.rpmMaxLbl.Location = new System.Drawing.Point(366, 47);
            this.rpmMaxLbl.Name = "rpmMaxLbl";
            this.rpmMaxLbl.Size = new System.Drawing.Size(13, 13);
            this.rpmMaxLbl.TabIndex = 53;
            this.rpmMaxLbl.Text = "0";
            // 
            // speedMinLbl
            // 
            this.speedMinLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speedMinLbl.AutoSize = true;
            this.speedMinLbl.Location = new System.Drawing.Point(334, 69);
            this.speedMinLbl.Name = "speedMinLbl";
            this.speedMinLbl.Size = new System.Drawing.Size(13, 13);
            this.speedMinLbl.TabIndex = 54;
            this.speedMinLbl.Text = "0";
            // 
            // speedMaxLbl
            // 
            this.speedMaxLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speedMaxLbl.AutoSize = true;
            this.speedMaxLbl.Location = new System.Drawing.Point(366, 69);
            this.speedMaxLbl.Name = "speedMaxLbl";
            this.speedMaxLbl.Size = new System.Drawing.Size(13, 13);
            this.speedMaxLbl.TabIndex = 55;
            this.speedMaxLbl.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Min";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Cur";
            // 
            // heartbeatCurLbl
            // 
            this.heartbeatCurLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heartbeatCurLbl.AutoSize = true;
            this.heartbeatCurLbl.Location = new System.Drawing.Point(403, 22);
            this.heartbeatCurLbl.Name = "heartbeatCurLbl";
            this.heartbeatCurLbl.Size = new System.Drawing.Size(13, 13);
            this.heartbeatCurLbl.TabIndex = 59;
            this.heartbeatCurLbl.Text = "0";
            // 
            // rpmCurLbl
            // 
            this.rpmCurLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rpmCurLbl.AutoSize = true;
            this.rpmCurLbl.Location = new System.Drawing.Point(403, 47);
            this.rpmCurLbl.Name = "rpmCurLbl";
            this.rpmCurLbl.Size = new System.Drawing.Size(13, 13);
            this.rpmCurLbl.TabIndex = 60;
            this.rpmCurLbl.Text = "0";
            // 
            // speedCurLbl
            // 
            this.speedCurLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speedCurLbl.AutoSize = true;
            this.speedCurLbl.Location = new System.Drawing.Point(403, 69);
            this.speedCurLbl.Name = "speedCurLbl";
            this.speedCurLbl.Size = new System.Drawing.Size(13, 13);
            this.speedCurLbl.TabIndex = 61;
            this.speedCurLbl.Text = "0";
            // 
            // distanceMinLbl
            // 
            this.distanceMinLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.distanceMinLbl.AutoSize = true;
            this.distanceMinLbl.Location = new System.Drawing.Point(334, 94);
            this.distanceMinLbl.Name = "distanceMinLbl";
            this.distanceMinLbl.Size = new System.Drawing.Size(13, 13);
            this.distanceMinLbl.TabIndex = 62;
            this.distanceMinLbl.Text = "0";
            // 
            // distanceMaxLbl
            // 
            this.distanceMaxLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.distanceMaxLbl.AutoSize = true;
            this.distanceMaxLbl.Location = new System.Drawing.Point(366, 94);
            this.distanceMaxLbl.Name = "distanceMaxLbl";
            this.distanceMaxLbl.Size = new System.Drawing.Size(13, 13);
            this.distanceMaxLbl.TabIndex = 63;
            this.distanceMaxLbl.Text = "0";
            // 
            // distanceCurLbl
            // 
            this.distanceCurLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.distanceCurLbl.AutoSize = true;
            this.distanceCurLbl.Location = new System.Drawing.Point(403, 94);
            this.distanceCurLbl.Name = "distanceCurLbl";
            this.distanceCurLbl.Size = new System.Drawing.Size(13, 13);
            this.distanceCurLbl.TabIndex = 64;
            this.distanceCurLbl.Text = "0";
            // 
            // powerMinLbl
            // 
            this.powerMinLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.powerMinLbl.AutoSize = true;
            this.powerMinLbl.Location = new System.Drawing.Point(334, 115);
            this.powerMinLbl.Name = "powerMinLbl";
            this.powerMinLbl.Size = new System.Drawing.Size(13, 13);
            this.powerMinLbl.TabIndex = 65;
            this.powerMinLbl.Text = "0";
            // 
            // powerMaxLbl
            // 
            this.powerMaxLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.powerMaxLbl.AutoSize = true;
            this.powerMaxLbl.Location = new System.Drawing.Point(366, 116);
            this.powerMaxLbl.Name = "powerMaxLbl";
            this.powerMaxLbl.Size = new System.Drawing.Size(13, 13);
            this.powerMaxLbl.TabIndex = 66;
            this.powerMaxLbl.Text = "0";
            // 
            // powerCurLbl
            // 
            this.powerCurLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.powerCurLbl.AutoSize = true;
            this.powerCurLbl.Location = new System.Drawing.Point(403, 115);
            this.powerCurLbl.Name = "powerCurLbl";
            this.powerCurLbl.Size = new System.Drawing.Size(13, 13);
            this.powerCurLbl.TabIndex = 67;
            this.powerCurLbl.Text = "0";
            // 
            // energyMinLbl
            // 
            this.energyMinLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.energyMinLbl.AutoSize = true;
            this.energyMinLbl.Location = new System.Drawing.Point(334, 139);
            this.energyMinLbl.Name = "energyMinLbl";
            this.energyMinLbl.Size = new System.Drawing.Size(13, 13);
            this.energyMinLbl.TabIndex = 68;
            this.energyMinLbl.Text = "0";
            // 
            // energyMaxLbl
            // 
            this.energyMaxLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.energyMaxLbl.AutoSize = true;
            this.energyMaxLbl.Location = new System.Drawing.Point(366, 138);
            this.energyMaxLbl.Name = "energyMaxLbl";
            this.energyMaxLbl.Size = new System.Drawing.Size(13, 13);
            this.energyMaxLbl.TabIndex = 69;
            this.energyMaxLbl.Text = "0";
            // 
            // energyCurLbl
            // 
            this.energyCurLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.energyCurLbl.AutoSize = true;
            this.energyCurLbl.Location = new System.Drawing.Point(403, 139);
            this.energyCurLbl.Name = "energyCurLbl";
            this.energyCurLbl.Size = new System.Drawing.Size(13, 13);
            this.energyCurLbl.TabIndex = 70;
            this.energyCurLbl.Text = "0";
            // 
            // actpowerMinLbl
            // 
            this.actpowerMinLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actpowerMinLbl.AutoSize = true;
            this.actpowerMinLbl.Location = new System.Drawing.Point(334, 162);
            this.actpowerMinLbl.Name = "actpowerMinLbl";
            this.actpowerMinLbl.Size = new System.Drawing.Size(13, 13);
            this.actpowerMinLbl.TabIndex = 71;
            this.actpowerMinLbl.Text = "0";
            // 
            // actpowerMaxLbl
            // 
            this.actpowerMaxLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actpowerMaxLbl.AutoSize = true;
            this.actpowerMaxLbl.Location = new System.Drawing.Point(366, 162);
            this.actpowerMaxLbl.Name = "actpowerMaxLbl";
            this.actpowerMaxLbl.Size = new System.Drawing.Size(13, 13);
            this.actpowerMaxLbl.TabIndex = 72;
            this.actpowerMaxLbl.Text = "0";
            // 
            // actpowerCurLbl
            // 
            this.actpowerCurLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actpowerCurLbl.AutoSize = true;
            this.actpowerCurLbl.Location = new System.Drawing.Point(403, 162);
            this.actpowerCurLbl.Name = "actpowerCurLbl";
            this.actpowerCurLbl.Size = new System.Drawing.Size(13, 13);
            this.actpowerCurLbl.TabIndex = 73;
            this.actpowerCurLbl.Text = "0";
            // 
            // ErgometerSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 276);
            this.Controls.Add(this.actpowerCurLbl);
            this.Controls.Add(this.actpowerMaxLbl);
            this.Controls.Add(this.actpowerMinLbl);
            this.Controls.Add(this.energyCurLbl);
            this.Controls.Add(this.energyMaxLbl);
            this.Controls.Add(this.energyMinLbl);
            this.Controls.Add(this.powerCurLbl);
            this.Controls.Add(this.powerMaxLbl);
            this.Controls.Add(this.powerMinLbl);
            this.Controls.Add(this.distanceCurLbl);
            this.Controls.Add(this.distanceMaxLbl);
            this.Controls.Add(this.distanceMinLbl);
            this.Controls.Add(this.speedCurLbl);
            this.Controls.Add(this.rpmCurLbl);
            this.Controls.Add(this.heartbeatCurLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedMaxLbl);
            this.Controls.Add(this.speedMinLbl);
            this.Controls.Add(this.rpmMaxLbl);
            this.Controls.Add(this.rpmMinLbl);
            this.Controls.Add(this.heartbeatMaxLbl);
            this.Controls.Add(this.heartbeatMinLbl);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.setTime);
            this.Controls.Add(this.text1Time);
            this.Controls.Add(this.countTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.setActualPower);
            this.Controls.Add(this.text2ActualPower);
            this.Controls.Add(this.text1ActualPower);
            this.Controls.Add(this.randomActualPower);
            this.Controls.Add(this.labelActualPower);
            this.Controls.Add(this.setEnergy);
            this.Controls.Add(this.text2Energy);
            this.Controls.Add(this.text1Energy);
            this.Controls.Add(this.randomEnergy);
            this.Controls.Add(this.labelEnergy);
            this.Controls.Add(this.setPower);
            this.Controls.Add(this.text2Power);
            this.Controls.Add(this.text1Power);
            this.Controls.Add(this.randomPower);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.setDistance);
            this.Controls.Add(this.text2Distance);
            this.Controls.Add(this.text1Distance);
            this.Controls.Add(this.randomDistance);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.setSpeed);
            this.Controls.Add(this.text2Speed);
            this.Controls.Add(this.text1Speed);
            this.Controls.Add(this.randomSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.setRPM);
            this.Controls.Add(this.text2RPM);
            this.Controls.Add(this.text1RPM);
            this.Controls.Add(this.randomRPM);
            this.Controls.Add(this.labelRPM);
            this.Controls.Add(this.setHeartBeat);
            this.Controls.Add(this.text2HeartBeat);
            this.Controls.Add(this.text1HeartBeat);
            this.Controls.Add(this.randomHeartBeat);
            this.Controls.Add(this.labelHeartBeat);
            this.Controls.Add(this.ComPortBox);
            this.Controls.Add(this.connectButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(444, 315);
            this.MinimumSize = new System.Drawing.Size(444, 315);
            this.Name = "ErgometerSimulator";
            this.Text = "Ergometer Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox ComPortBox;
        private System.Windows.Forms.Label labelHeartBeat;
        private System.Windows.Forms.CheckBox randomHeartBeat;
        private System.Windows.Forms.TextBox text1HeartBeat;
        private System.Windows.Forms.TextBox text2HeartBeat;
        private System.Windows.Forms.Button setHeartBeat;
        private System.Windows.Forms.Button setRPM;
        private System.Windows.Forms.TextBox text2RPM;
        private System.Windows.Forms.TextBox text1RPM;
        private System.Windows.Forms.CheckBox randomRPM;
        private System.Windows.Forms.Label labelRPM;
        private System.Windows.Forms.Button setSpeed;
        private System.Windows.Forms.TextBox text2Speed;
        private System.Windows.Forms.TextBox text1Speed;
        private System.Windows.Forms.CheckBox randomSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Button setDistance;
        private System.Windows.Forms.TextBox text2Distance;
        private System.Windows.Forms.TextBox text1Distance;
        private System.Windows.Forms.CheckBox randomDistance;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Button setPower;
        private System.Windows.Forms.TextBox text2Power;
        private System.Windows.Forms.TextBox text1Power;
        private System.Windows.Forms.CheckBox randomPower;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Button setEnergy;
        private System.Windows.Forms.TextBox text2Energy;
        private System.Windows.Forms.TextBox text1Energy;
        private System.Windows.Forms.CheckBox randomEnergy;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.Button setActualPower;
        private System.Windows.Forms.TextBox text2ActualPower;
        private System.Windows.Forms.TextBox text1ActualPower;
        private System.Windows.Forms.CheckBox randomActualPower;
        private System.Windows.Forms.Label labelActualPower;
        private System.Windows.Forms.Button setTime;
        private System.Windows.Forms.TextBox text1Time;
        private System.Windows.Forms.CheckBox countTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label heartbeatMinLbl;
        private System.Windows.Forms.Label heartbeatMaxLbl;
        private System.Windows.Forms.Label rpmMinLbl;
        private System.Windows.Forms.Label rpmMaxLbl;
        private System.Windows.Forms.Label speedMinLbl;
        private System.Windows.Forms.Label speedMaxLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label heartbeatCurLbl;
        private System.Windows.Forms.Label rpmCurLbl;
        private System.Windows.Forms.Label speedCurLbl;
        private System.Windows.Forms.Label distanceMinLbl;
        private System.Windows.Forms.Label distanceMaxLbl;
        private System.Windows.Forms.Label distanceCurLbl;
        private System.Windows.Forms.Label powerMinLbl;
        private System.Windows.Forms.Label powerMaxLbl;
        private System.Windows.Forms.Label powerCurLbl;
        private System.Windows.Forms.Label energyMinLbl;
        private System.Windows.Forms.Label energyMaxLbl;
        private System.Windows.Forms.Label energyCurLbl;
        private System.Windows.Forms.Label actpowerMinLbl;
        private System.Windows.Forms.Label actpowerMaxLbl;
        private System.Windows.Forms.Label actpowerCurLbl;
    }
}

