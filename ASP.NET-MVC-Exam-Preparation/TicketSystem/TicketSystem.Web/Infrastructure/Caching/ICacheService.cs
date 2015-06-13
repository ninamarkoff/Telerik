using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem.Web.Infrastructure.Caching
{
    public interface ICacheService
    {
        T Get<T>(string cacheKey, Func<T> getItemCallback) where T : class;

        void Clear(string cacheID);
    }
}
