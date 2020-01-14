using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    class Store
    {
        private string Marka;
        private int Voltage;
        private int Warranty;

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
