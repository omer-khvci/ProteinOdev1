using Data.Context;
using Data.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Concrete
{
    public class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : class
    {
        protected readonly AppDbContext Context;
        private DbSet<Entity> entities;
        
        public BaseRepository(AppDbContext context)
        {
            Context = context;
            this.entities = Context.Set<Entity>();
        }
        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return await entities.AsNoTracking().ToListAsync();
        }

        public async Task<Entity> GetByIdAsync(int id)
        {
            return await entities.Where(entity => EF.Property<int>(entity, "Id").Equals(id)).SingleAsync();
        }

        public async Task InsertAsync(Entity entity)
        {
            await entities.AddAsync(entity);
        }

        public void RemoveAsync(Entity entity)
        {
            entity.GetType().GetProperty("IsDeleted").SetValue(entity, true);
        }

        public void Update(Entity entity)
        {
            entities.Update(entity);
        }
    }
}
