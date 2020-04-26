using System;
using System.Collections.Generic;

namespace UserCom.Model
{
    public class PaginatedResult<T>
    {
        public Lazy<PaginatedResult<T>>? Next { get; set; }

        public Lazy<PaginatedResult<T>>? Previous { get; set; }

        public int Count { get; set; }

        public IReadOnlyList<T> Results { get; set; }
    }
}