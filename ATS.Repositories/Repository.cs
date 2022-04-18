using ATS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Repositories
{
     public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;
        public Repository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public T Get(long Id)
        {
            return entities.SingleOrDefault(e => e.Id == Id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }

        public void Insert(T Entity)
        {
            entities.Add(Entity);
            context.SaveChanges();
        }

        public void Remove(T Entity)
        {
            entities.Remove(Entity);
            context.SaveChanges();
        }

        public void Update(T ob)
        {
            context.Entry(ob).State = EntityState.Modified;
        }
    }
}
