using FastEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SuperNote.Application.Notes.Queries.GetNoteById;
using SuperNote.Domain.Notes;
using SuperNote.WebApi.Extensions;

namespace SuperNote.WebApi.EndPoints.Notes.GetById
{
    public class GetById(IMediator mediator)
    : Endpoint<GetNoteByIdRequest, NoteDto>
    {
        public override void Configure()
        {
            AllowAnonymous();

            Get("/notes/{noteId:guid}/");

            Summary(s =>
            {
                s.Summary = "Retrieve a note by its ID.";
            });
        }

        public override async Task HandleAsync(
             GetNoteByIdRequest req, CancellationToken ct)
        {
            var note = await mediator
                       .Send(new GetNoteByIdQuery(new NoteId(req.NoteId)), ct);

            if (note.IsSuccess)
            {
                await SendOkAsync(note.Value, ct);
            }
            else
            {
                await this.SendProblemDetailsResponse(note, ct);
            }
        }
    }
}
