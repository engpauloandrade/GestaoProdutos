namespace GestaoProdutos.Domain.Model
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }

        public PagedResult(List<T> items, int totalCount, bool hasNext)
        {
            Items = items;
            TotalCount = totalCount;
            HasNext = hasNext;
        }
    }
}
