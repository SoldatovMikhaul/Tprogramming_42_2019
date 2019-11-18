using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class TV
    {
        private int number;
        private bool turnon;

        public TV()
        : this(1)
        {
        }

        public TV(int number)
        : this(number, true, "samsung")
        {
        }

        public TV(int number, bool turnon, string marka)
        {
            Number = number;
            Turnon = turnon;
            Marka = marka;
        }

        public string Marka { get; set; }

        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                if (value >= 0 && value < 101)
                {
                    this.number = value;
                }
                else
                {
                    Console.WriteLine("Number should be > 0 and < than 101");
                }
            }
        }

        public bool Turnon
        {
            get
            {
                return this.turnon;
            }

            set
            {
                if (value == false || value == true)
                {
                    this.turnon = value;
                }
                else
                {
                    Console.WriteLine("Не правильно введено новое значение включения или выключения");
                }
            }
        }

        public void GetInfo()
        {
            if (turnon == true)
            {
                Console.WriteLine($"Включено,Марка:{Marka},Номер канала:{Number}");
            }
            else
            {
                Console.WriteLine($"Вsключено,Марка:{Marka}");
            }
        }

        public void TurnonTV()
        {
            Console.WriteLine($"{Marka}:включено");
        }

        public void ChanelUp()
        {
            this.number++;
        }
    }
}
