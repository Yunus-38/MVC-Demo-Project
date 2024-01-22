using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Services.Core
{
    public interface IService<T> where T : CoreEntity
    {
        public bool Add(T item);
        public bool Update(T item);
        
        public int Save();
        public T GetById(int id);
        public List<T> GetAll();
        public List<T> GetByDefault(Expression<Func<T, bool>> exp);
    }
}
