using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class СlockAppliance : Appliances
    {
        // private DateTime time1;
        // private int brightness;
        public СlockAppliance()
        : this(" ")
        {
        }

        public СlockAppliance(string nazvanie)
        : this(nazvanie, "untitled")
        {
        }

        public СlockAppliance(string nazvanie, string marka)
        : this(nazvanie, marka, 220)
        {
        }

        public СlockAppliance(string nazvanie, string marka, int voltage)
        : this(nazvanie, marka, voltage, 1)
        {
        }

        public СlockAppliance(string nazvanie, string marka, int voltage, int warranty)
        : this(nazvanie, marka, voltage, warranty, new DateTime(12, 30, 35))
        {
        }

        public СlockAppliance(string nazvanie, string marka, int voltage, int warranty, DateTime time1)
        : base(nazvanie, marka, voltage, warranty)
        {
            this.Time2 = time1;
        }

        public override string Broke()
        {
            return "Your Appliance is broken";
        }

        /*public override DateTime Time2
        {
            get
            {
                return base.Time2;
            }

            set
            {
                if ((value >= new DateTime(0, 0, 0)) && (value < new DateTime(24, 60, 60)))
                {
                    base.Time2 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Time", "Unacceptable time");
                }
            }
        }*/
    }
}