using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Data.Infrastructure
{
    //generic method in all solution
    public interface IRepository<T> where T : class
    {
        T Add(T Entity);

        void Update(T Entity);

        T Delete(T Entity);

        T Delete(object id);

        void DeleteMulti(Expression<Func<T, bool>> where);

        T GetSingelById(object id);

        // get singel T by condition
        T GetSingelByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IEnumerable<T> GetMulti(Expression<Func<T, bool>> expression, string[] includes = null);
        /// <summary>
        /// get mutil paging
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="total"></param>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);
        /// <summary>
        /// cout T
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        int Count(Expression<Func<T, bool>> where);
        /// <summary>
        /// check contains T
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        bool CheckConstains(Expression<Func<T, bool>> predicate);

        IEnumerable<T> GetAll(string[] includes = null);
    }


}
