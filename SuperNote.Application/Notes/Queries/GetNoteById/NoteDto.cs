using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperNote.Application.Notes.Queries.GetNoteById
{
    public record NoteDto(
    Guid Id,
    string Text,
    DateTime LastModified);
}
