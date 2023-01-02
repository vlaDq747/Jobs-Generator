using System.ComponentModel.DataAnnotations.Schema;

namespace SchGenerator.Models
{
    [Table("Events")]
    public class ActualSchedule
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("Title")]
        public string Title { get; set; }

    }
}
