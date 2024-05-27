using SuperNote.Domain.Abstractions.DomainEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperNote.Domain.Abstractions.Aggregates
{
    public abstract class AggregateRoot
    {
        private readonly List<IDomainEvent> _domainEvents = new();

        public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents;

        protected void RaiseDomainEvent(IDomainEvent domainEvent)
           => _domainEvents.Add(domainEvent);

        public void ClearDomainEvents() => _domainEvents.Clear();
    }
}
