public interface IQueryDispatcher<T> where T : IQuery
{
    IEnumerable<IQueryResult> Send(T query);
}