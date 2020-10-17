using FeedbackOfPost.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackOfPost.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDBContext _db;
        public GenericRepository(AppDBContext appDBContext)
        {
            _db = appDBContext;
        }
        public async void Add(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
        }

        public void Remove(T entity)
        {
            _db.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
        }

        public async Task<T> Get(int id)
        {
            return await _db.Set<T>().FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _db.Set<T>().ToListAsync();
        }
    }
}
