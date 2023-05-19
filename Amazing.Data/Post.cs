namespace Amazing.Data
{
    public class Post
    {
        public uint Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public User? Author { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateEdited { get; set; }
    }
}