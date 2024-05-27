using SuperNote.Domain.Abstractions.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperNote.Domain.Abstractions.DataAccess
{
    public interface IRepository<TEntity> where TEntity : AggregateRoot
    {
        Task<IReadOnlyList<TEntity>> GetALl();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
