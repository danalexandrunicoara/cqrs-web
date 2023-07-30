public class QueryDispatcher<T> : IQueryDispatcher<T> where T : IQuery
{
    private readonly IQueryHandler<T> _queryHandler;
    public QueryDispatcher(IQueryHandler<T> queryHandler) => _queryHandler = queryHandler;
    public IEnumerable<IQueryResult> Send(T query)
    {
        return _queryHandler.Handle(query);
    }
}