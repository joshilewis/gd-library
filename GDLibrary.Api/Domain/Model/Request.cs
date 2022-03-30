namespace GDLibrary.Api.Domain.Model
{
    public class Request
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public Book Book { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool Active { get; set; }

        public Request(Book book, string email)
        {
            Book = book;
            Email = email;
            TimeStamp = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            Active = true;
        }

        protected Request()
        {
            
        }

    }
}
