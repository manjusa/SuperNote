using Microsoft.AspNetCore.Mvc;

namespace SuperNote.WebApi.EndPoints.Notes.GetById
{
    public class GetNoteByIdRequest
    {
        [FromRoute]
        public Guid NoteId { get; set; }
    }
}
