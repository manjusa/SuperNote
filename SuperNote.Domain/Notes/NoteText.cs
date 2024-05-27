using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperNote.Domain.Notes
{
    public sealed record NoteText
    {
        public string Value { get; }

        private NoteText(string value) => Value = value;

        public static Result<NoteText> Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return NoteErrors.TheNoteIsEmpty;
            }

            return Result.Ok(new NoteText(value));
        }
    }
}
