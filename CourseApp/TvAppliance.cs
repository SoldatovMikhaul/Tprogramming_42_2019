using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class TvAppliance : Appliances
    {
        private int number;
        private int brightness;

        public TvAppliance()
        : this(1)
        {
        }

        public TvAppliance(int number)
        : this(number, 1)
        {
        }

        public TvAppliance(int number, int brightness)
        : this(number, brightness, " ")
        {
        }

        public TvAppliance(int number, int brightness, string marka)
        {
            Number = number;
            Brightness = brightness;
            Marka = marka;
        }

        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                if (value >= 1 && value < 101)
                {
                    this.number = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Number", "Number should be >= 1 and =< than 101");
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

        public override string Broke()
        {
            return "This Apppliance is broken((";
        }

        public void Turn()
        {
            Console.WriteLine("Включено");
        }

        public void NextChanel()
        {
            this.number++;
        }

        public void BrightnessDown()
        {
            this.brightness--;
        }
    }
}
