using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgometerSimulator
{
    class DataGenerator
    {
        Random rand;

        public ValueSetting HeartBeat { get; set; }
        public ValueSetting RPM { get; set; }
        public ValueSetting Speed { get; set; }
        public ValueSetting Distance { get; set; }
        public ValueSetting Power { get; set; }
        public ValueSetting Energy { get; set; }
        public ValueSetting ActualPower { get; set; }
        public ValueSetting Time { get; set; }

        private double lastTime;

        public DataGenerator()
        {
            rand = new Random();
            HeartBeat = new ValueSetting(false, 0, 0);
            RPM = new ValueSetting(false, 0, 0);
            Speed = new ValueSetting(false, 0, 0);
            Distance = new ValueSetting(false, 0, 0);
            Power = new ValueSetting(false, 0, 0);
            Energy = new ValueSetting(false, 0, 0);
            ActualPower = new ValueSetting(false, 0, 0);
            Time = new ValueSetting(false, 0, 0);

            lastTime = (DateTime.Now - DateTime.Parse("1/1/1870 0:0:0")).TotalMilliseconds;
        }

        public void Reset()
        {
            HeartBeat = new ValueSetting(false, 0, 0);
            RPM = new ValueSetting(false, 0, 0);
            Speed = new ValueSetting(false, 0, 0);
            Distance = new ValueSetting(false, 0, 0);
            Power = new ValueSetting(false, 0, 0);
            Energy = new ValueSetting(false, 0, 0);
            ActualPower = new ValueSetting(false, 0, 0);
            Time = new ValueSetting(false, 0, 0);

            lastTime = (DateTime.Now - DateTime.Parse("1/1/1870 0:0:0")).TotalMilliseconds;
        }

        public void Update()
        {
            //Hearbeat
            if(HeartBeat.random)
            {
                HeartBeat.currentvalue = rand.Next(HeartBeat.value1, HeartBeat.value2);
            }
            else
            {
                HeartBeat.currentvalue = HeartBeat.value1;
            }
            //RPM
            if (RPM.random)
            {
                RPM.currentvalue = rand.Next(RPM.value1, RPM.value2);
            }
            else
            {
                RPM.currentvalue = RPM.value1;
            }
            //Speed
            if (Speed.random)
            {
                Speed.currentvalue = rand.Next(Speed.value1, Speed.value2);
            }
            else
            {
                Speed.currentvalue = Speed.value1;
            }
            //Distance
            if (Distance.random)
            {
                Distance.currentvalue = rand.Next(Distance.value1, Distance.value2);
            }
            else
            {
                Distance.currentvalue = Distance.value1;
            }
            //Power
            if (Power.random)
            {
                Power.currentvalue = rand.Next(Power.value1, Power.value2);
            }
            else
            {
                Power.currentvalue = Power.value1;
            }
            //Energy
            if (Energy.random)
            {
                Energy.currentvalue = rand.Next(Energy.value1, Energy.value2);
            }
            else
            {
                Energy.currentvalue = Energy.value1;
            }
            //ActualPower
            if (ActualPower.random)
            {
                ActualPower.currentvalue = rand.Next(ActualPower.value1, ActualPower.value2);
            }
            else
            {
                ActualPower.currentvalue = ActualPower.value1;
            }
            //Time
            if ((DateTime.Now - DateTime.Parse("1/1/1870 0:0:0")).TotalMilliseconds - lastTime > 1000)
            {
                if (Time.random) // false = up; true = down;
                {
                    if (Time.value1 - 1 <= 0)
                        Time.value1 = 0;
                    else
                        Time.value1 = Time.value1 - 1;

                    Time.currentvalue = Time.value1;
                }
                else
                {
                    Time.value1 = Time.value1 + 1;
                    Time.currentvalue = Time.value1;
                }

                lastTime = (DateTime.Now - DateTime.Parse("1/1/1870 0:0:0")).TotalMilliseconds;
            }
        }
    }
}
