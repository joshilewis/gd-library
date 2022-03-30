using GDLibrary.Api.Domain.Model;

namespace GDLibrary.Api.Domain.Queries
{
    public interface IFindRequestById
    {
        Request? Execute(int id);
    }
}
