using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClass
{
    public abstract class Appliances
    {
        private int voltage;

        public Appliances()
        : this("")
        {
        }

        public Appliances(string nazvanie)
        : this("Televizor", "samsung")
        {
        }

        public Appliances(string nazvanie, string marka)
        : this("Televizor", "samsung", 0)
        {
        }

        public Appliances(string nazvanie, string marka, int voltage)
        : this(nazvanie, marka, voltage, 220)
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
                if (value <= 0 && value > 220)
                {
                    this.voltage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("voltage should be > 0 and < than 220");
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
                if (Marka != "")
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

        public void ByNew(Appliances Televizor)
        {
            if (Voltage > 0)
            {
                if (Marka != "")
                {
                    Marka = Televizor.Marka;
                    Voltage = Televizor.Voltage;
                    Warranty = Televizor.Warranty;
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

