using SuperNote.Domain.Abstractions.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperNote.Domain.Notes
{
    public class NoteNotFoundError : DomainError
    {
        public NoteNotFoundError(string code, string message)
            : base(message, code)
        {
            WithMetadata(nameof(ErrorType), ErrorType.NotFound);
        }
    }
}
