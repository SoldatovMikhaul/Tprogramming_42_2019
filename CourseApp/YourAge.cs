using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class YourAge
    {
        public static DateTime DateComparison(DateTime date1, DateTime date2)
        {
            long a = Math.Abs(date2.Ticks - date1.Ticks);
            if (a < 10000001)
            {
                throw new ArgumentOutOfRangeException("Вас не существует((");
            }

            if (date1.Ticks < date2.Ticks)
            {
                var res = new DateTime(date2.Ticks - date1.Ticks);
                return res;
            }

            throw new ArgumentOutOfRangeException("Вас не существует((");
        }

        public static string DateComparison2(DateTime date1, DateTime date2)
        {
            long a = Math.Abs(date2.Ticks - date1.Ticks);
            if (a < 10000001)
            {
                throw new ArgumentOutOfRangeException("Вас не существует((");
            }

            if (date1.Ticks < date2.Ticks)
            {
                var res = new DateTime(date2.Ticks - date1.Ticks);
                return $"Вам {res.Year - 1} лет, {res.Month - 1} месяцев и {res.Day - 1} дня";
            }

            throw new ArgumentOutOfRangeException("Вас не существует((");
        }

        public static string YourAgeNow()
        {
            Console.WriteLine("Введите год вашего рождения:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц вашего рождения:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите день вашего рождения:");
            int day = int.Parse(Console.ReadLine());
            DateTime res = DateComparison(new DateTime(year, month, day), DateTime.Now);
            return $"Вам {res.Year - 1} лет, {res.Month - 1} месяцев и {res.Day - 1} дня";
        }

        public static string YourAgeNow(int y, int m, int d)
        {
            DateTime res = DateComparison(new DateTime(y, m, d), DateTime.Now);
            return $"Вам {res.Year - 1} лет, {res.Month - 1} месяцев и {res.Day - 1} дня";
        }

        public static string YourAgeNow(DateTime date)
        {
            DateTime res = DateComparison(date, DateTime.Now);
            return $"Вам {res.Year - 1} лет, {res.Month - 1} месяцев и {res.Day - 1} дня";
        }
    }
}
