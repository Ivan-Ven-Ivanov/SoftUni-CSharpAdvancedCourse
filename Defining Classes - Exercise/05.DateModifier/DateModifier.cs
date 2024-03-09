using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public static class DateModifier
    {
        
        public static int DifferenceBetweenDates(string startDate, string endDate)
        {
            DateTime firstDate = DateTime.Parse(startDate);
            DateTime lastDate = DateTime.Parse(endDate);

            TimeSpan difference = firstDate - lastDate;

            return Math.Abs(difference.Days);
        }
    }
}
