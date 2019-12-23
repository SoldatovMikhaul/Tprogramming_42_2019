using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    class Store
    {
        public string Marka ;
        public int Voltage;
        public int Warranty;
        public void BuyNew(string marka, int voltage, int warranty)
        {
            if ((Voltage > 0) && (Marka != string.Empty))
            {
                Marka = marka;
                Voltage = voltage;
                Warranty = warranty;
            }
            else
            {
                throw new ArgumentOutOfRangeException("You Appliances willn't work");
            }
        }
    }
}
