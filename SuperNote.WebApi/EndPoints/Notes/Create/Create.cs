using FastEndpoints;
using MediatR;
using SuperNote.Application.Notes.Commands.CreateNote;
using SuperNote.WebApi.Extensions;

namespace SuperNote.WebApi.EndPoints.Notes.Create
{
    public class Create(IMediator mediator)
    : Endpoint<CreateNoteRequest, CreateNoteResponse>
    {
        public override void Configure()
        {
            AllowAnonymous();

            Post("/notes/");

            Summary(s =>
            {
                s.Summary = "Create a new note.";
            });
        }

        public override async Task HandleAsync(
              CreateNoteRequest req, CancellationToken ct)
        {
            var result = await mediator
                .Send(new CreateNoteCommand(req.Text), ct);

            if (result.IsSuccess)
            {
                await SendOkAsync(new CreateNoteResponse(result.Value), ct);
            }
            else
            {
                await this.SendProblemDetailsResponse(result, ct);
            }
        }
    }
}
