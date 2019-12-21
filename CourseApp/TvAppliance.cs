using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class TvAppliance : Appliances
    {
        private const int DefoltNumChanel = 1;
        private const int DefoltVoltage = 220;
        private const int DefoltNumWarranty = 1;

        public TvAppliance()
        : this(" ")
        {
        }

        public TvAppliance(string nazvanie)
        : this(nazvanie, "untitled")
        {
        }

        public TvAppliance(string nazvanie, string marka)
        : this(nazvanie, marka, DefoltVoltage)
        {
        }

        public TvAppliance(string nazvanie, string marka, int voltage)
        : this(nazvanie, marka, voltage, DefoltNumWarranty)
        {
        }

        public TvAppliance(string nazvanie, string marka, int voltage, int warranty)
        : this(nazvanie, marka, voltage, warranty, DefoltNumChanel)
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
                    throw new ArgumentOutOfRangeException("Number should be > 0 and < than 100");
                }
            }
        }

        public override string Broke()
        {
            return "Your Appliance is broken";
        }
    }
}
