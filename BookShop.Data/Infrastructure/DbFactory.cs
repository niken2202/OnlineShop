using BookShop.Data.Infrastructure;
using BookShop.Model.Models;
namespace BookShop.Data
{
    public class DbFactory : Disposeable, IDbFactory
    {
       private OnlineShopDbContext dbContext;
        public OnlineShopDbContext Init()
        {
            return dbContext ?? (dbContext = new OnlineShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
