using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErgometerSimulator
{
    public partial class ErgometerSimulator : Form
    {
        ComPort comPort;
        DataGenerator dg;
        CommandParser parser;

        public ErgometerSimulator()
        {
            InitializeComponent();
            comPort = new ComPort(this);
            dg = new DataGenerator();
            parser = new CommandParser(dg);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!comPort.IsOpen())
            {
                if (comPort.Connect(ComPortBox.Text))
                {
                    connectButton.Text = "Disconnect";
                    ToggleAllComponents(true);
                    updateTimer.Start();
                }
            }
            else
            {
                if (comPort.Disconnect())
                {
                    connectButton.Text = "Connect";
                    ToggleAllComponents(false);
                    updateTimer.Stop();
                }
            }
        }

        public void ReceivedCommand(string command)
        {
            string response = parser.Parse(command);
            string display = command + " :_: " + response;
            Console.WriteLine(display);
            comPort.Write(response);
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            dg.Update();

            labelCurrentTime.Text = dg.Time.currentvalue / 60 + ":" + dg.Time.currentvalue % 60;

            heartbeatMinLbl.Text = dg.HeartBeat.value1 + "";
            heartbeatMaxLbl.Text = dg.HeartBeat.value2 + "";
            heartbeatCurLbl.Text = dg.HeartBeat.currentvalue + "";

            rpmMinLbl.Text = dg.RPM.value1 + "";
            rpmMaxLbl.Text = dg.RPM.value2 + "";
            rpmCurLbl.Text = dg.RPM.currentvalue + "";

            speedMinLbl.Text = dg.Speed.value1 + "";
            speedMaxLbl.Text = dg.Speed.value2 + "";
            speedCurLbl.Text = dg.Speed.currentvalue + "";

            distanceMinLbl.Text = dg.Distance.value1 + "";
            distanceMaxLbl.Text = dg.Distance.value2 + "";
            distanceCurLbl.Text = dg.Distance.currentvalue + "";

            powerMinLbl.Text = dg.Power.value1 + "";
            powerMaxLbl.Text = dg.Power.value2 + "";
            powerCurLbl.Text = dg.Power.currentvalue + "";

            energyMinLbl.Text = dg.Energy.value1 + "";
            energyMaxLbl.Text = dg.Energy.value2 + "";
            energyCurLbl.Text = dg.Energy.currentvalue + "";

            actpowerMinLbl.Text = dg.ActualPower.value1 + "";
            actpowerMaxLbl.Text = dg.ActualPower.value2 + "";
            actpowerCurLbl.Text = dg.ActualPower.currentvalue + "";

        }

        private void setHeartBeat_Click(object sender, EventArgs e)
        {
            if(text1HeartBeat.Text != "" && (text2HeartBeat.Text != "" || !randomHeartBeat.Checked))
            {
                dg.HeartBeat = new ValueSetting(randomHeartBeat.Checked, int.Parse(text1HeartBeat.Text), (text2HeartBeat.Enabled ? int.Parse(text2HeartBeat.Text) : 0));
                text1HeartBeat.Text = "";
                text2HeartBeat.Text = "";
            }
        }

        private void setRPM_Click(object sender, EventArgs e)
        {
            if (text1RPM.Text != "" && (text2RPM.Text != "" || !randomRPM.Checked))
            {
                dg.RPM = new ValueSetting(randomRPM.Checked, int.Parse(text1RPM.Text), (text2RPM.Enabled ? int.Parse(text2RPM.Text) : 0));
                text1RPM.Text = "";
                text2RPM.Text = "";
            }
        }

        private void setSpeed_Click(object sender, EventArgs e)
        {
            if (text1Speed.Text != "" && (text2Speed.Text != "" || !randomSpeed.Checked))
            {
                dg.Speed = new ValueSetting(randomSpeed.Checked, int.Parse(text1Speed.Text), (text2Speed.Enabled ? int.Parse(text2Speed.Text) : 0));
                text1Speed.Text = "";
                text2Speed.Text = "";
            }
        }

        private void setDistance_Click(object sender, EventArgs e)
        {
            if (text1Distance.Text != "" && (text2Distance.Text != "" || !randomDistance.Checked))
            {
                dg.Distance = new ValueSetting(randomDistance.Checked, int.Parse(text1Distance.Text), (text2Distance.Enabled ? int.Parse(text2Distance.Text) : 0));
                text1Distance.Text = "";
                text2Distance.Text = "";
            }
        }

        private void setPower_Click(object sender, EventArgs e)
        {
            if (text1Power.Text != "" && (text2Power.Text != "" || !randomPower.Checked))
            {
                dg.Power = new ValueSetting(randomPower.Checked, int.Parse(text1Power.Text), (text2Power.Enabled ? int.Parse(text2Power.Text) : 0));
                text1Power.Text = "";
                text2Power.Text = "";
            }
        }

        private void setEnergy_Click(object sender, EventArgs e)
        {
            if (text1Energy.Text != "" && (text2Energy.Text != "" || !randomEnergy.Checked))
            {
                dg.Energy = new ValueSetting(randomEnergy.Checked, int.Parse(text1Energy.Text), (text2Energy.Enabled ? int.Parse(text2Energy.Text) : 0));
                text1Energy.Text = "";
                text2Energy.Text = "";
            }
        }

        private void setActualPower_Click(object sender, EventArgs e)
        {
            if (text1ActualPower.Text != "" && (text2ActualPower.Text != "" || !randomActualPower.Checked))
            {
                dg.ActualPower = new ValueSetting(randomActualPower.Checked, int.Parse(text1ActualPower.Text), (text2ActualPower.Enabled ? int.Parse(text2ActualPower.Text) : 0));
                text1ActualPower.Text = "";
                text2ActualPower.Text = "";
            }
        }

        private void setTime_Click(object sender, EventArgs e)
        {
            if(text1Time.Text != "")
            {
                string[] temp = text1Time.Text.Split(':');
                if(temp.Length == 2)
                {
                    int minutes = int.Parse(temp[0]);
                    int seconds = int.Parse(temp[1]) + (minutes * 60);
                    dg.Time = new ValueSetting(countTime.Checked, seconds, 0);
                    text1Time.Text = "";
                }
                
            }
        }

        private void ToggleAllComponents(bool enabled)
        {
            //Random checkboxes
            randomActualPower.Enabled = enabled;
            randomActualPower.Checked = false;

            randomDistance.Enabled = enabled;
            randomDistance.Checked = false;

            randomEnergy.Enabled = enabled;
            randomEnergy.Checked = false;

            randomHeartBeat.Enabled = enabled;
            randomHeartBeat.Checked = false;

            randomRPM.Enabled = enabled;
            randomRPM.Checked = false;

            randomSpeed.Enabled = enabled;
            randomSpeed.Checked = false;

            randomPower.Enabled = enabled;
            randomPower.Checked = false;

            countTime.Enabled = enabled;
            countTime.Checked = false;


            //First text boxes
            text1ActualPower.Enabled = enabled;
            text1ActualPower.Text = "";

            text1Distance.Enabled = enabled;
            text1Distance.Text = "";

            text1Energy.Enabled = enabled;
            text1Energy.Text = "";

            text1HeartBeat.Enabled = enabled;
            text1HeartBeat.Text = "";

            text1Power.Enabled = enabled;
            text1Power.Text = "";

            text1RPM.Enabled = enabled;
            text1RPM.Text = "";

            text1Speed.Enabled = enabled;
            text1Speed.Text = "";

            text1Time.Enabled = enabled;
            text1Time.Text = "";

           
            //Second text boxes
            text2ActualPower.Enabled = false;
            text2ActualPower.Text = "";

            text2Distance.Enabled = false;
            text2Distance.Text = "";

            text2Energy.Enabled = false;
            text2Energy.Text = "";

            text2HeartBeat.Enabled = false;
            text2HeartBeat.Text = "";

            text2Power.Enabled = false;
            text2Power.Text = "";

            text2RPM.Enabled = false;
            text2RPM.Text = "";

            text2Speed.Enabled = false;
            text2Speed.Text = "";

            labelCurrentTime.Text = "00:00";


            //Buttons
            setHeartBeat.Enabled = enabled;
            setDistance.Enabled = enabled;
            setPower.Enabled = enabled;
            setActualPower.Enabled = enabled;
            setTime.Enabled = enabled;
            setRPM.Enabled = enabled;
            setEnergy.Enabled = enabled;
            setSpeed.Enabled = enabled;

            //ComPort Box
            ComPortBox.Enabled = !enabled;
        }

        private void randomHeartBeat_CheckedChanged(object sender, EventArgs e)
        {
            if(randomHeartBeat.Checked)
                text2HeartBeat.Enabled = true;
            else
            {
                text2HeartBeat.Enabled = false;
                text2HeartBeat.Text = "";
            }
        }

        private void randomRPM_CheckedChanged(object sender, EventArgs e)
        {
            if (randomRPM.Checked)
                text2RPM.Enabled = true;
            else
            {
                text2RPM.Enabled = false;
                text2RPM.Text = "";
            }
        }

        private void randomSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (randomSpeed.Checked)
                text2Speed.Enabled = true;
            else
            {
                text2Speed.Enabled = false;
                text2Speed.Text = "";
            }
        }

        private void randomDistance_CheckedChanged(object sender, EventArgs e)
        {
            if (randomDistance.Checked)
                text2Distance.Enabled = true;
            else
            {
                text2Distance.Enabled = false;
                text2Distance.Text = "";
            }
        }

        private void randomPower_CheckedChanged(object sender, EventArgs e)
        {
            if (randomPower.Checked)
                text2Power.Enabled = true;
            else
            {
                text2Power.Enabled = false;
                text2Power.Text = "";
            }
        }

        private void randomEnergy_CheckedChanged(object sender, EventArgs e)
        {
            if (randomEnergy.Checked)
                text2Energy.Enabled = true;
            else
            {
                text2Energy.Enabled = false;
                text2Energy.Text = "";
            }
        }

        private void randomActualPower_CheckedChanged(object sender, EventArgs e)
        {
            if (randomActualPower.Checked)
                text2ActualPower.Enabled = true;
            else
            {
                text2ActualPower.Enabled = false;
                text2ActualPower.Text = "";
            }
        }
    }
}
