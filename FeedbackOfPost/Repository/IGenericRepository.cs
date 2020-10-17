using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackOfPost.Repository
{
    public interface IGenericRepository<T> where T:class
    {
        Task<T> Get(int id);

        Task<IEnumerable<T>> GetAll();

        void Add(T entity);

        void Remove(T entity);

        void Update(T entity);
    }
}
