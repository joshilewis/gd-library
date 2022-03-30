using GDLibrary.Api.Domain.Model;
using GDLibrary.Api.Domain.Queries;

namespace GDLibrary.Api.Domain.Services.DeleteARequest
{
    public class DeleteRequestHandler
    {
        private readonly IFindRequestById findRequestById;
        private readonly IUpdateRequest updateRequest;

        public DeleteRequestHandler(IFindRequestById findRequestById, IUpdateRequest updateRequest)
        {
            this.findRequestById = findRequestById;
            this.updateRequest = updateRequest;
        }

        public void Execute(DeleteRequestCommand command)
        {
            Request? request = findRequestById.Execute(command.Id);
            if (request == null) return;

            request.Deactivate();
            updateRequest.Execute(request);
        }
    }
}
