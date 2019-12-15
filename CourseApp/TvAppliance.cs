using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class TvAppliance : Appliances
    {
        private int number;

        public TvAppliance()
        : this(" ")
        {
        }

        public TvAppliance(string nazvanie)
        : this(nazvanie, "untitled")
        {
        }

        public TvAppliance(string nazvanie, string marka)
        : this(nazvanie, marka, 220)
        {
        }

        public TvAppliance(string nazvanie, string marka, int voltage)
        : this(nazvanie, marka, voltage, 1)
        {
        }

        public TvAppliance(string nazvanie, string marka, int voltage, int warranty)
        : this(nazvanie, marka, voltage, warranty, 1)
        {
        }

        public TvAppliance(string nazvanie, string marka, int voltage, int warranty, int number)
        : base(nazvanie, marka, voltage, warranty)
        {
            this.Number = number;
        }

        public override int Number
        {
            get
            {
                return base.Number;
            }

            set
            {
                if (value > 0 && value <= 100)
                {
                    base.Number = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("voltage should be > 0 and < than 220");
                }
            }
        }

        public override string Broke()
        {
            return "Your Appliance is broken";
        }
    }
}
