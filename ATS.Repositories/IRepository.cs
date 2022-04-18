using ATS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Repositories
{
    public interface IRepository<T> where T:BaseEntity
    {
        T Get(long Id);
        IEnumerable<T> GetAll();
        void Update(T Entity);
        void Remove(T Entity);
        void Insert(T Entity);

    }
}
