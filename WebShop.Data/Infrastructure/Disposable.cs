using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        public bool _isDisposed;
        ~Disposable()
        {
            Dispose(false);
        }

        private void Dispose(bool isDisposing)
        {
            if(!_isDisposed && isDisposing)
            {
                // khi dang disposed cho phep tu dinh nghi
                DisposeCore();
            }
            _isDisposed = true;
        }

        protected virtual void DisposeCore()
        {
            
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
