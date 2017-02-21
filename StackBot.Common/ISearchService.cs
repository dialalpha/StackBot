namespace StackBot.Common
{
    public interface ISearchService
    {
        SearchResponse Search(SearchRequest req);
    }
}
