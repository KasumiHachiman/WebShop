using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// luu nhung thay doi day xuong database bao bao section
        /// </summary>
        private readonly IDbFactory _dbFactory;
        private WebShopDbContext _dbContext;
        public UnitOfWork(IDbFactory dbFactory)
        {
            this._dbFactory = dbFactory;
        }
        public WebShopDbContext DbContext
        {
            get { return _dbContext ?? (_dbContext = _dbFactory.Init()); }
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
