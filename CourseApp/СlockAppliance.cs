using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class СlockAppliance : Appliances
    {
        private DateTime time;
        private int brightness;

        public СlockAppliance()
        : this(new DateTime(2005, 11, 20, 12, 1, 10))
        {
        }

        public СlockAppliance(DateTime time)
        : this(time, 1)
        {
        }

        public СlockAppliance(DateTime time, int brightness)
        : this(time, brightness, " ")
        {
        }

        public СlockAppliance(DateTime time, int brightness, string marka)
        {
            Time = time;
            Brightness = brightness;
            Marka = marka;
        }

        public DateTime Time
        {
            get
            {
                return this.time;
            }

            set
            {
                if ((value >= new DateTime(2000, 0, 0, 0, 0, 0)) && (value < new DateTime(2000, 12, 31, 24, 60, 60)))
                {
                    this.time = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Time", "Unacceptable time");
                }
            }
        }

        public override int Voltage
        {
            get
            {
                return base.Voltage;
            }

            set
            {
                if (value <= 0 && value > 220)
                {
                    base.Voltage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("voltage should be > 0 and < than 220");
                }
            }
        }

        public int Brightness
        {
            get
            {
                return this.brightness;
            }

            set
            {
                if (value >= 1 && value < 99)
                {
                    this.brightness = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Brightness should be >= 1 and < than 99");
                }
            }
        }

        public override string Broke()
        {
            return "This Apppliance is broken((";
        }
    }
}
