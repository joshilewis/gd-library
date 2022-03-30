using GDLibrary.Api.Domain.Model;

namespace GDLibrary.Api.Domain.Queries
{
    public interface IGetActiveRequestByBookId
    {
        Request? Execute(int id);
    }
}
