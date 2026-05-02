namespace UNI__PLANNER.Services
{
    public class ScheduleHelper
    {
        // 🔹 تحديد هل الأسبوع Odd ولا Even (بناءً على الأسبوع في السنة)
        public bool IsOddWeek(DateTime date)
        {
            int weekNumber = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                date,
                System.Globalization.CalendarWeekRule.FirstDay,
                DayOfWeek.Saturday);

            return weekNumber % 2 != 0;
        }

        // 🔹 تحديد اسم اليوم الحقيقي
        public string GetDayName(DateTime date)
        {
            return date.DayOfWeek.ToString();
        }
    }
}