using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErgometerApplication
{
    public class PanelClientActions : Panel
    {
        private int _currentAction;
        public int CurrentAction => _currentAction;

        List<string> actions;

        public PanelClientActions(): base()
        {
            actions = new List<string>();
            actions.Add("Test actie 1");
            actions.Add("Test actie 2");
            actions.Add("Test actie 3");
            actions.Add("Test actie 4");
            actions.Add("Test actie 5");

            actions.Add("Test actie 4");
            actions.Add("Test actie 5");
            actions.Add("Test actie 4");
            actions.Add("Test actie 5");
            actions.Add("Test actie 4");
            actions.Add("Test actie 5");
            actions.Add("Test actie 4");
            actions.Add("Test actie 5");
            foreach (string a in actions)
            {
                this.Controls.Add(actionLabel(a));
            }

            this.Location = new System.Drawing.Point(0, 0);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.Size = new System.Drawing.Size(390, 400);
            setActiveColor(_currentAction);
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

            if(id < actions.Count && id >= 0)
            {
                this.Controls[id].BackColor = System.Drawing.Color.LawnGreen;
                this. Controls[id].ForeColor = System.Drawing.Color.White;
            }
        }

        public void NextAction(int minute)
        {
            if (minute > _currentAction)
            {
                _currentAction++;
                setActiveColor(_currentAction);                
            }
        }
    }
}
