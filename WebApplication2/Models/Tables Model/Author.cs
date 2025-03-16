using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Author
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Listeners")]
        public int Listeners { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        public Author(int Id, string Name, int Listeners, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Listeners = Listeners;
            this.Description = Description;
        }
    }
}
