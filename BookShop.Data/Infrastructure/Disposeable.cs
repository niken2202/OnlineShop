using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Infrastructure
{
    public class Disposeable : IDisposable
    {
        private bool isDisposed;
        public void Dispose(bool disposing)
        {
            if(!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Disposeable()
        {
            Dispose(false);
        }
        //override this to dispose custom object
        protected virtual void DisposeCore()
        {

        }
    }
}
