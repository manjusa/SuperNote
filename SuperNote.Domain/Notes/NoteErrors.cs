using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperNote.Domain.Notes
{
    public static class NoteErrors
    {
        public static readonly NoteNotFoundError NoteNotFound = new("note.not.found", "Note not found.");
        public static readonly NoteTextIsEmptyError TheNoteIsEmpty = new("the.note.is.empty", "The note is empty.");
    }
}
