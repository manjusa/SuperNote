using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperNote.Domain.Notes
{
    public record struct NoteId(Guid Value)
    {
        public static NoteId New() => new NoteId(Guid.NewGuid());

    }
}
        