﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApplication2.Models;
using WebApplication2.Repositories.Core;

namespace WebApplication2.Repositories.Implementation
{
    public class CategoryRepository<T> : ICategoryRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public CategoryRepository(AppDbContext context)
        {
                _context = context;
                _dbSet = _context.Set<T>();   
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);  
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
           await _dbSet.AddRangeAsync(entities);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
           await _context.Set<T>().AnyAsync(expression);
           return true; 
        }

        public IQueryable GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable(); 
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);   
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
