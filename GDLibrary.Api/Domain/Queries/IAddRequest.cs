using GDLibrary.Api.Domain.Model;

namespace GDLibrary.Api.Domain.Queries
{
    public interface IAddRequest
    {
        void Execute(Request request);
    }
}
