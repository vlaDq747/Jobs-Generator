namespace SchGenerator
{
    internal static class StandardNote
    {
        public static string GetStandartNote(this DateTime date)
        {
            string result = string.Empty;

            switch (date.DayOfWeek)
            {
                case DayOfWeek.Tuesday:
                    result = date.ToString("18:00 Общая молитва");
                    break;

                case DayOfWeek.Wednesday:
                    result = date.IsBeforeFirstSunday() ? date.ToString("19:00 Молодёжное служение")
                                                        : string.Empty;
                    break;

                case DayOfWeek.Thursday:
                    result = date.ToString("19:00 Богослужение (ЧТ)");
                    break;

                case DayOfWeek.Friday:
                    result = date.IsBeforeFirstSunday() ? string.Empty
                                                        : date.ToString("19:00 Молодёжное служение");
                    break;

                case DayOfWeek.Saturday:
                    result = date.IsBeforeFirstSunday() ? date.ToString("00:00 Ночная молитва\n \n16:00 Подростковое служение")
                                                        : date.ToString("16:00 Подростковое служение");
                    break;

                case DayOfWeek.Sunday:
                    result = date.ToString("10:00 Богослужение (ВС, утро)\n  \n18:00 Богослужение (ВС, вечер)");
                    break;
            }

            return result;
        }
    }
}
