using System;
using static System.Console;

namespace LR3
{
    public class Date
    {
        int day;
        int month;
        int year;

        public Date(int day, int month, int year)
        {
            if (day < 1) this.day = 1;
            else if (day > 31) this.day = 31;
            else this.day = day;

            if (month < 1) this.month = 1;
            else if (month > 12) this.month = 12;
            else this.month = month;

            if (year < 1) this.year = 1;
            else this.year = year;
        }

        public void PrintTemplate1()
        {
            WriteLine($"{day} {MonthName(month)} {year} year.");
        }

        public void PrintTemplate2()
        {
            WriteLine($"{day}.{month}.{year}");
        }

        public string CorrectDate()
        {
            int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month < 1 || month > 12) return "False";
            if (day < 1 || day > months[month]) return "False";
            if (year < 1) return "False";
            return "True";
        }

        private int CountDay(int year)
        {
            int result = 0;

            int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int sum = 0;

            for(int i = 0; i < months.Length; i++)
            {
                sum += months[i];
            }

            result = sum * year;

            return result;
        }
        public void CountDayBetweenTwoDate(Date date)
        {
            int first = CountDay (this.year);
            int second = CountDay (date.year);

            int result = Math.Abs(first - second);

            WriteLine($"Result: {result}");
        }

        public void Century()
        {
            int century = (int)Math.Ceiling((double)year / 100);
            WriteLine($"Century: {century}");
        }
        public static string MonthName(int month)
        {
            if (month < 1 || month > 12) return "Invalid month";
            
            switch (month)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: return "Invalid month";
            }
        }
    }
}
