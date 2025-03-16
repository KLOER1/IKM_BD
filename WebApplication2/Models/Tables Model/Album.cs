using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Album
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Release_date")]
        public DateOnly ReleaseDate { get; set; }

        public Album(int Id, string Title, DateOnly ReleaseDate)
        {
            this.Id = Id;
            this.Title = Title;
            this.ReleaseDate = ReleaseDate;
        }
    }
}
