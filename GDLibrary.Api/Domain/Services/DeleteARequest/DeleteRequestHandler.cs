using GDLibrary.Api.Domain.Model;
using GDLibrary.Api.Domain.Queries;

namespace GDLibrary.Api.Domain.Services.DeleteARequest
{
    public class DeleteRequestHandler
    {
        private readonly IGetActiveRequestByBookId _getActiveRequestByBookId;
        private readonly IUpdateRequest updateRequest;

        public DeleteRequestHandler(IGetActiveRequestByBookId getActiveRequestByBookId, IUpdateRequest updateRequest)
        {
            this._getActiveRequestByBookId = getActiveRequestByBookId;
            this.updateRequest = updateRequest;
        }

        public void Execute(DeleteRequestCommand command)
        {
            Request? request = _getActiveRequestByBookId.Execute(command.Id);
            if (request == null) return;

            request.Deactivate();
            updateRequest.Execute(request);
        }
    }
}
