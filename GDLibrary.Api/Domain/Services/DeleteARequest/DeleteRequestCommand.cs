using System.ComponentModel.DataAnnotations;

namespace GDLibrary.Api.Domain.Services.DeleteARequest
{
    public class DeleteRequestCommand
    {
        [Required]
        public int Id { get; }

        public DeleteRequestCommand(int id)
        {
            Id = id;
        }

        protected DeleteRequestCommand()
        {
            
        }

    }
}
