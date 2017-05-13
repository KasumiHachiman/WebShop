using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        /// <summary>
        /// khong can new model ma thong qua dbfactory de khoi tao doi tuong
        /// </summary>
        private WebShopDbContext _dbContext;
        public WebShopDbContext Init()
        {
            return _dbContext ?? (_dbContext = new WebShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}
