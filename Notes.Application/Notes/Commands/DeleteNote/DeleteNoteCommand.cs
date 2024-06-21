using MediatR;

namespace Notes.Application.Notes.Commands.DeleteNote
{
    internal class DeleteNoteCommand : IRequest
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}
