namespace SchGenerator
{
    public static class DateHelper
    {
        internal static bool IsBeforeFirstSunday(this DateTime date)
        {
            var closestsunday = date.Next(DayOfWeek.Sunday);
            var week = closestsunday.GetWeekOfMonth();

            return week == 1;
        }
    }
}