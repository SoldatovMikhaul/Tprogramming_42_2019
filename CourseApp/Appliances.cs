using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{
    public abstract class Appliances
    {
        private int number;
        private int voltage;
        private DateTime time2 = new DateTime(2022, 12, 28);

        public Appliances()
        : this(" ")
        {
        }

        public Appliances(string nazvanie)
        : this(nazvanie, "untitled")
        {
        }

        public Appliances(string nazvanie, string marka)
        : this(nazvanie, marka, 220)
        {
        }

        public Appliances(string nazvanie, string marka, int voltage)
        : this(nazvanie, marka, voltage, 1)
        {
        }

        public Appliances(string nazvanie, string marka, int voltage, int warranty)
        {
            Nazvanie = nazvanie;
            Marka = marka;
            Voltage = voltage;
            Warranty = warranty;
        }

        public virtual int Voltage
        {
            get
            {
                return this.voltage;
            }

            set
            {
                if (value > 0 && value <= 220)
                {
                    this.voltage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("voltage should be > 0 and < than 220");
                }
            }
        }

        public virtual int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                if (value > 0 && value <= 100)
                {
                    this.number = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("voltage should be > 0 and < than 220");
                }
            }
        }

        public virtual DateTime Time2
        {
            get
            {
                return this.time2;
            }

            set
            {
                if ((value >= new DateTime(2000, 1, 1)) && (value < new DateTime(2022, 12, 30)))
                {
                    this.time2 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Unacceptable time");
                }
            }
        }

        public string Nazvanie { get; set; }

        public int Warranty { get; set; }

        public string Marka { get; set; }

        public void ByNew(string marka, int voltage, int warranty)
        {
            if (Voltage > 0)
            {
                if (Marka != " ")
                {
                    Marka = marka;
                    Voltage = voltage;
                    Warranty = warranty;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("You Appliances willn't work");
            }
        }

        public void ByNew(Appliances televizor)
        {
            if (Voltage > 0)
            {
                if (Marka != " ")
                {
                    Marka = televizor.Marka;
                    Voltage = televizor.Voltage;
                    Warranty = televizor.Warranty;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("You Appliances willn't work");
            }
        }

        public override string ToString()
        {
            string s = $"You want to by {Nazvanie}, marka: {Marka}, voltage: {Voltage},vith warranty on {Warranty}";
            return s;
        }

        public abstract string Broke();
    }
}