namespace SchGenerator
{
    static internal class CheckNextDays
    {
        internal static DateTime Next(this DateTime from, DayOfWeek dayofweek)
        {
            int start = (int)from.DayOfWeek;
            int target = (int)dayofweek;
            if (target <= start)
                target += 7;
            return from.AddDays(target - start);
        }
    }
}
