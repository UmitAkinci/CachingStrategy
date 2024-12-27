using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adesso.Caching
{
    public class CacheItem<T>
    {
        public string Key { get; set; }

        public T Value { get; set; }
    }
}
