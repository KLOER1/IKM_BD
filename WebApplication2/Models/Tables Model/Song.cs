﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Song
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Duration")]
        public short Duration { get; set; }

        [Column("Auditions")]
        public long Auditions { get; set; }

        [Column("Explicit")]
        public bool Explicit { get; set; }

        [Column("AlbumId")]
        public int AlbumId { get; set; }

        public Song(int Id, string Title, short Duration, long Auditions, bool Explicit, int AlbumId)
        {
            this.Id = Id;
            this.Title = Title;
            this.Duration = Duration;
            this.Auditions = Auditions;
            this.Explicit = Explicit;
            this.AlbumId = AlbumId;
        }
    }
}
