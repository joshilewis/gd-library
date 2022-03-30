using GDLibrary.Api.Domain.Model;

namespace GDLibrary.Api.Domain.Queries
{
    public interface IGetBookByTitle
    {
        Book? Execute(string title);
    }
}
