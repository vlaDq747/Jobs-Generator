using SchGenerator.Models;
using Microsoft.EntityFrameworkCore;

namespace SchGenerator
{
    public class DateService
    {
        public async Task SetStandartSheduleAsync()
        {
            using (var context = new ScheduleContext())
            {
                await context.Database.ExecuteSqlRawAsync("TRUNCATE TABLE [Events]");

                DateTime start = DateTime.Now;
                DateTime end = start.AddMonths(3);
                end = new DateTime(end.Year, end.Month, 1);
                end.AddDays(-1);

                for (DateTime date = start; date <= end; date = date.AddDays(1))
                {
                    var author = new ActualSchedule
                    {
                        Title = date.GetStandartNote(),
                    };
                    context.ActualSchedules.Add(author);
                }
                context.SaveChanges();
            }
        }
    }
}
