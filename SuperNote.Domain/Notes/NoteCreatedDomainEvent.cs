using SuperNote.Domain.Abstractions.DomainEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperNote.Domain.Notes
{
    public record NoteCreatedDomainEvent(NoteId NoteId) : IDomainEvent;

}
