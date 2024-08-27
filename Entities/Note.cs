namespace INote.Entities
{
    public class Note : BaseEntity
    {
        public string Content { get; set; }
        public string Message { get; set; }
        public bool Isvibule { get; set; }
    }
}
