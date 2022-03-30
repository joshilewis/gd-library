using GDLibrary.Api.Domain.Model;

namespace GDLibrary.Api.Domain.Queries
{
    public interface IUpdateRequest
    {
        void Execute(Request request);
    }
}
