using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Application.Repositories;
using OnionArchitecture.Domain.Entities.Common;
using OnionArchitecture.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly OnionArchitectureDbContext _context;

        public ReadRepository(OnionArchitectureDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();
        public IQueryable<T> GetAll() => Table;
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression) => Table.Where(expression);
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression) => await Table.FirstOrDefaultAsync(expression);

        public async Task<T> GetByIdAsync(string id)
            //=> await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
            => await Table.FindAsync(Guid.Parse(id));
    }
}
