using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErgometerApplication
{
    public class PanelClientActions : Panel
    {
        List<string> actions;

        public PanelClientActions(int stepID) : base()
        {
            actions = new List<string>();
            actions.Add("Stage 1: Rustig roeien");
            actions.Add("Stage 1: Power Level: 40");
            actions.Add("Stage 1: Power Level: 55");
            actions.Add("Stage 1: Power Level: 70");
            actions.Add("Stage 1: Power Level: 85");
            actions.Add("Stage 2: Stage 2 begint");
            actions.Add("Stage 2: Power Level: 100");
            actions.Add("Stage 2: Power Level: 115");
            actions.Add("Stage 2: Power Level: 130");
            actions.Add("Stage 2: Power Level: 145");
            actions.Add("Stage 3: Stage 3 begint");
            actions.Add("Stage 3: Power Level: 160");
            actions.Add("Stage 3: Power Level: 175");
            actions.Add("Stage 3: Power Level: 190");
            actions.Add("Stage 3: Power Level: 205");

            foreach (string a in actions)
            {
                this.Controls.Add(actionLabel(a));
            }
            Console.WriteLine("STEP ID:" + stepID);
            for (int i = 0; i <= stepID; i++)
            {
                setActiveColor(i);
            }

            this.Location = new System.Drawing.Point(0, 0);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.Size = new System.Drawing.Size(390, 400);

        }

        private Label actionLabel(string action)
        {
            Label label = new Label();
            label.Dock = DockStyle.Bottom;
            label.Text = action;
            label.AutoSize = false;
            label.Size = new System.Drawing.Size(300, 40);
            label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            return label;
        }

        public void setActiveColor(int id)
        {
            
            if (id < actions.Count)
            {
                this.Controls[id].BackColor = System.Drawing.Color.Orange;
                this.Controls[id].ForeColor = System.Drawing.Color.White;
            }

            id--;

            if (id < actions.Count && id >= 0)
            {
                this.Controls[id].BackColor = System.Drawing.Color.LawnGreen;
                this.Controls[id].ForeColor = System.Drawing.Color.White;
            }
        }

    }
}
