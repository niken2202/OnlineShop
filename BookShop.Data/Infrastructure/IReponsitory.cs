using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Infrastructure
{
    public interface IReponsitory<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteMulti(Expression<Func<T, bool>> where);
        T GetSingleById(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IQueryable GetAll(string includes = null);
        IQueryable GetMulti(Expression<Func<T, bool>> predicate, string includes = null);
        IQueryable GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string includes = null);
        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);


    }
}
