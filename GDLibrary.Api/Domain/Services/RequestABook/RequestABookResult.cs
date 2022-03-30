namespace GDLibrary.Api.Domain.Services.RequestABook
{
    public class RequestABookResult : Result
    {
        public int Id { get; set; }
        public bool Available { get; set; }
        public string Title { get; set; }
        public DateTime Timestamp { get; set; }

        public RequestABookResult(int id, bool available, string title, DateTime timestamp)
            : base()
        {
            Id = id;
            Available = available;
            Title = title;
            Timestamp = timestamp;

        }

        public RequestABookResult(string message)
            : base(message)
        {
            Id = 0;
            Available = false;
            Title = string.Empty;
        }
    }
}
