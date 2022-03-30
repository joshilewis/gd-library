using GDLibrary.Api.Domain.Model;

namespace GDLibrary.Api.Domain.Queries
{
    public interface ISaveRequest
    {
        void Execute(Request request);
    }
}
