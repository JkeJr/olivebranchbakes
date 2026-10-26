using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace OliveBranchBakes.Objects
{
    public class DateRange
    {
        private DateTime startDate { get; init; }
        private DateTime endDate { get; init; }

        public string Start => AbbreviateDate(startDate);
        public string End => (endDate.Year > startDate.Year) ? $"{AbbreviateDate(endDate)}+" : AbbreviateDate(endDate);

        public DateRange(DateTime start, DateTime end)
        {
            startDate = start;
            endDate = end;
        }
        public DateRange(string start, string end)
        {
            startDate = ConvertToDateTime(start);
            endDate = ConvertToDateTime(end);
        }

        private static string AbbreviateDate(DateTime date) => $"{date.Month}/{date.Day}";

        public DateTime? this[int i]
        {
            get
            {
                if (i == 0)
                    return startDate;
                else if (i == 1)
                    return endDate;
                return null;
            }
        }
        public static int GetYear() => DateTime.Today.Year;

        // turn mm/dd into mm/dd/yyyy
        public static string FormatDate(string date)
        {
            string dateFormatted;

            // if date == mm/dd+, set the end DateTime to be set for the next year
            if (date[date.Length - 1] == '+')
                dateFormatted = $"{date.Substring(0, date.Length - 1)}/{GetYear() + 1}"; // mm/dd + /(yyyy + 1)
            else
                dateFormatted = $"{date}/{GetYear()}"; // mm/dd + yyyy
            return dateFormatted;
        }
        // turn DateTime into mm/dd/yyyy
        public static string FormatDate(DateTime dateTime) => $"{dateTime.Month}/{dateTime.Day}/{dateTime.Year}";

        // convert mm/dd into DateTime
        public static DateTime ConvertToDateTime(string date)
        {
            date = FormatDate(date);

            int[] intValues = new int[3];
            string[] strValues = date.Split("/");
            foreach (string value in strValues)
            {
                intValues[strValues.IndexOf(value)] = Convert.ToInt16(value);
            }

            DateTime dateTime = new(intValues[2], intValues[0], intValues[1]);
            return dateTime;
        }
    }
}
