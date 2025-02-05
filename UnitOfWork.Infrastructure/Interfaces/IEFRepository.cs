﻿using System.Linq.Expressions;

namespace UnitOfWork.Infrastructure.Interfaces
{
    public interface IEFRepository<T> where T : class
    {
        public ICollection<T> ToList();
        public Task<ICollection<T>> ToListAsync();
        public Task<T> RegisterAsync(T objeto);

        public Task<T> UpdateAsync(T objeto);

        public Task DeleteAsync(T objeto);

        public Task<T?> RecoverBy(Expression<Func<T, bool>> condicao);

        public Task RegisterList(ICollection<T> listObjects);
        public IEnumerable<T> RecoverListAsync(Expression<Func<T, bool>> condicao);

    }
}
