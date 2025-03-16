namespace WebApplication2.Models
{
    public class UpdatePlaylist
    {
        public int IdSong { get; set; }

        public int IdAuthor { get; set; }

        public int NewId { get; set; }

        public UpdatePlaylist() { }

        public UpdatePlaylist(int IdSong, int IdAuthor)
        {
            this.IdSong = IdSong;
            this.IdAuthor = IdAuthor;
        }
    }
}
