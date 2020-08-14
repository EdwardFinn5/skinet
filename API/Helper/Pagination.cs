using System.Collections.Generic;

namespace API.Helper
{
    public class Pagination<T> where T : class
    {
        public Pagination(int pageInd, int pageSize, int count, IReadOnlyList<T> data)
        {
            PageInd = pageInd;
            PageSize = pageSize;
            Count = count;
            Data = data;
        }

        public int PageInd { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public IReadOnlyList<T> Data { get; set; }
    }
}