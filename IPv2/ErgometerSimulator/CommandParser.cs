using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgometerSimulator
{
    class CommandParser
    {
        private DataGenerator dg;

        public CommandParser(DataGenerator dg)
        {
            this.dg = dg;
        }

        public string Parse(string input)
        {
            string response = "";

            switch(input)
            {
                case "CM":
                    break;
                case "RS":
                    response = "ACK";
                    dg.Reset();
                    break;
                case "ST":
                    response += dg.HeartBeat.currentvalue  + "\t"; //Heartbeat
                    response += dg.RPM.currentvalue   + "\t"; //RPM
                    response += dg.Speed.currentvalue  + "\t"; //Speed
                    response += dg.Distance.currentvalue + "\t"; //Distance
                    response += dg.Power.currentvalue  + "\t"; //Power
                    response += dg.Energy.currentvalue    + "\t"; //Energy
                    response += (dg.Time.currentvalue/60)   + ":" + (dg.Time.currentvalue%60) + "\t"; //Time
                    response += dg.ActualPower.currentvalue;         //ActualPower
                    break;
                default:
                    break;
            }
            if (input.StartsWith("PT"))
            {
                dg.Time.currentvalue = int.Parse(input.Substring(3, 2)) * 60 + int.Parse(input.Substring(5, 2));
                dg.Time = new ValueSetting(true, int.Parse(input.Substring(3, 2)) * 60 + int.Parse(input.Substring(5, 2)), 0);
                Console.WriteLine(dg.Time.currentvalue);
            }
            else if (input.StartsWith("PD"))
            {
                dg.Distance.currentvalue = int.Parse(input.Substring(3));
                dg.Distance.value1 = int.Parse(input.Substring(3));
                Console.WriteLine(dg.Distance.currentvalue);
            }
            else if (input.StartsWith("PW"))
            {
                dg.Power.currentvalue = int.Parse(input.Substring(3));
                dg.Power.value1 = int.Parse(input.Substring(3));
                Console.WriteLine(dg.Power.currentvalue);
            }
            else if (input.StartsWith("PE"))
            {
                dg.Energy.currentvalue = int.Parse(input.Substring(3));
                dg.Energy.value1 = int.Parse(input.Substring(3));
                Console.WriteLine(dg.Energy.currentvalue);
            }
            return response;
        }
    }
}
