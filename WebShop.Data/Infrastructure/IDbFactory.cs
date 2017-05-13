using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        // giao tiep khoi tao model
        WebShopDbContext Init();
    }
}
