namespace GDLibrary.Api.Domain.Model
{
    public class Request
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public Book Book { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}
