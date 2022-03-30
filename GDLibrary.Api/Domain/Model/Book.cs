namespace GDLibrary.Api.Domain.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        protected Book()
        {
            
        }

        public Book(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
