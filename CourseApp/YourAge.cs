using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class YourAge
    {
        public static DateTime DateСomparison(DateTime dat1, DateTime dat2)
        {
            if (dat1.Ticks < dat2.Ticks)
            {
                var diff = new DateTime(dat2.Ticks - dat1.Ticks);
                return diff;
            }

            throw new ArgumentOutOfRangeException("Вас не существует");
        }

        public static string YourAgeNow()
        {
            Console.WriteLine("Введите ваш год рождения:");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц вашего рождения:");
            int months = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день вашего рождения:");
            int days = Convert.ToInt32(Console.ReadLine());
            DateTime result = DateСomparison(new DateTime(years, months, days), DateTime.Now);
            return $"Ваш возоаст: {result.Year - 1} лет {result.Month - 1} месяцев и {result.Day - 1} дня";
        }

        public static string YourAgeNow(int y, int m, int d)
        {
            DateTime result = DateСomparison(new DateTime(y, m, d), DateTime.Now);
            return $"Вам {result.Year - 1} лет, {result.Month - 1} месяцев и {result.Day - 1} дня";
        }

        public static string YouAgeNow(DateTime dat)
        {
            DateTime result = DateСomparison(dat, DateTime.Now);
            return $"Ваш возоаст: {result.Year - 1} лет {result.Month - 1} месяцев и {result.Day - 1} дня";
        }
    }
}
