public interface IQueryHandler<T> where T : IQuery
{
    IEnumerable<IQueryResult> Handle(T query);
}