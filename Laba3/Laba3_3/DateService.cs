using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_3
{
    public class DateService
    {

        public static DateOnly GetDate()
        {
            DateOnly date;
            Console.Write("Enter date:   ");
            while(true)
            {
                if (!DateOnly.TryParse(Console.ReadLine(), out date))
                {
                    Console.WriteLine("Incorrect date!!!\n Try again");
                    //return date;
                }
                else
                    return date;
            }
        }
        public static string DayOfWeek(DateOnly data)
        {
            Console.WriteLine(DateTime.Today.ToShortDateString());
            return data.DayOfWeek.ToString();
        }

        public static int GetDaysSpan(int day, int month, int year)
        {
            DateOnly CurrDay = new (year, month, day);
            return Math.Abs(DateOnly.Parse(DateTime.Today.ToShortDateString()).DayNumber - CurrDay.DayNumber);
        }
    }
}
